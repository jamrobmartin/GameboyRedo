using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameboyRedo
{
    internal class Gameboy: INotifyPropertyChanged
    {
        #region Singleton
        private static readonly Lazy<Gameboy> lazy = new Lazy<Gameboy>(() => new Gameboy());

        

        public static Gameboy Instance { get; private set; } = lazy.Value;
        #endregion

        #region Components

        public CPU CPU { get; set; }

        public Clock Clock { get; set; }

        #endregion

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private bool _powered = false;
        public bool Powered
        {
            get => _powered;
            private set
            {
                if (_powered != value)
                {
                    _powered = value;
                    OnPropertyChanged();
                }
            }
        }

        private Gameboy()
        {
            Clock = new Clock();
            CPU = new CPU();
        }

        public void Initialize()
        {
            // Nothing for now...
        }

        public void PowerOn()
        {
            Logger.WriteLine("Gameboy Powered ON", Logger.LogLevel.Information);
            Powered = true;
            //CPU.PowerOn();
            Clock.PowerOn();
        }

        public void PowerOff()
        {
            Logger.WriteLine("Gameboy Powered OFF", Logger.LogLevel.Information);
            Powered = false;

            Clock.PowerOff();
            //CPU.PowerOff();

        }

    }
}
