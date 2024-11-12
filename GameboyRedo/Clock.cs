using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GameboyRedo
{
    public enum EClockType
    {
        Continuous,
        SingleTCycle,
        SingleMCycle
    }

    public class Clock : INotifyPropertyChanged
    {
        public event Action Tick;
        public event PropertyChangedEventHandler? PropertyChanged;

        private const int ClockFrequency = 4194304; // 4.194304 MHz

        private Thread? _clockThread;

        private EClockType _clockType = EClockType.Continuous;
        public EClockType ClockType
        {
            get => _clockType;
            set
            {
                if(_clockType != value)
                {
                    _clockType = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private bool _running = false;
        public bool Running
        {
            get => _running;
            set
            {
                if(_running != value)
                {
                    _running = value;
                    OnPropertyChanged();
                }
                
            }
        }

        private bool _paused = false;
        public bool Paused
        {
            get => _paused;
            set
            {
                if (_paused != value)
                {
                    _paused = value;
                    OnPropertyChanged();
                }

            }
        }


        private bool _powered = false;
        public bool Powered
        {
            get => _powered;
            set
            {
                if (_powered != value)
                {
                    _powered = value;
                    OnPropertyChanged();
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Clock()
        {
            // Delay starting the clock thread until power-on
        }

        public void PowerOn()
        {
            if (!Powered)
            {
                Powered = true;
            }
        }

        public void PowerOff()
        {
            if (Powered)
            {
                Powered = false;
            }
        }

        public void ChangeClockType(EClockType type)
        {
            if (_clockType == EClockType.Continuous && _running)
            {
                Logger.WriteLine("Can't change ClockType while Continuous Clock is already running", Logger.LogLevel.Error);
                return;
            }

            _clockType = type;
        }

        #region ManualTicking
        public void DoTick()
        {
            if (_clockType == EClockType.SingleTCycle)
            {
                ProcessSingleTCycle();
            }
            else if (_clockType == EClockType.SingleMCycle)
            {
                ProcessSingleMCycle();
            }
        }
        #endregion

        #region SingleTCycle
        public void ProcessSingleTCycle()
        {
            Logger.WriteLine("SingleTCycle()", Logger.LogLevel.Debug);
            Tick?.Invoke();
        }
        #endregion

        #region SingleMCycle
        public void ProcessSingleMCycle()
        {
            // 1 M-Cycle = 4 T-Cycles
            Logger.WriteLine("SingleMCycle()", Logger.LogLevel.Debug);
            for (int i = 0; i < 4; i++)
            {
                ProcessSingleTCycle();
            }
        }
        #endregion

        #region ContinuousLoop

        private void ClockLoop()
        {
            bool debug = true; // Set this to false when debugging is over.

            const int tCyclesPerSecond = 4194304; // 4.194304 MHz
            const int tCyclesPerMCycle = 4;
            int mCyclesPerSecond = debug ? 2 : tCyclesPerSecond / tCyclesPerMCycle; // 1,048,576 M-cycles per second

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            while (_running)
            {
                if (Powered && !Paused)
                {
                    // Process one M-cycle
                    ProcessSingleMCycle();

                    // Wait for the remainder of the M-cycle to maintain frequency
                    while (stopwatch.ElapsedTicks < (Stopwatch.Frequency / mCyclesPerSecond))
                    {
                        // Spin-wait to achieve the correct timing for each M-cycle
                        if (!_running) 
                            return; // Exit immediately if _running is false
                    }

                    // Restart the stopwatch only if we’re still running
                    if (_running) stopwatch.Restart();
                }
                else
                {
                    Thread.Sleep(10);
                }
            }

            Logger.WriteLine("ClockLoop Ending...", Logger.LogLevel.Debug);
        }

        private void StartContinuousClock()
        {
            if (_clockThread == null || !_clockThread.IsAlive)
            {
                _running = true;
                _clockThread = new Thread(ClockLoop)
                {
                    IsBackground = true
                };
                _clockThread.Start();
            }
        }

        private void StopContinuousClock()
        {
            _running = false;
            if (_clockThread != null && _clockThread.IsAlive)
            {
                _clockThread.Join();
            }
        }

        public void Play()
        {
            if(!Running)
            {
                StartContinuousClock();
            }
        }

        public void Stop()
        {
            if (Running)
            {
                StopContinuousClock();
            }
        }

        public void TogglePause()
        {
            Paused = !Paused;
        }

        public void Pause()
        {
            Paused = true;
        }

        public void Unpause()
        {
            Paused = false;
        }

        #endregion
    }
}
