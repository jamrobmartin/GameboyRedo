using System;
using System.Collections.Concurrent;
using System.Threading;

namespace GameboyRedo
{
    public static class Logger
    {
        public static LogLevel Level { get; set; } = LogLevel.Debug;

        public enum LogLevel
        {
            Error,
            Information,
            Debug
        }

        public class LoggerMessageEventArgs : EventArgs
        {
            public LogLevel Level { get; set; } = LogLevel.Debug;
            public string Message { get; set; } = "";
        }

        public static event EventHandler<LoggerMessageEventArgs> MessageLogged = delegate { };

        private static readonly ConcurrentQueue<LoggerMessageEventArgs> _logQueue = new();
        private static readonly Thread _logThread;
        private static bool _isRunning = true;

        static Logger()
        {
            // Start the background logging thread
            _logThread = new Thread(ProcessLogQueue)
            {
                IsBackground = true
            };
            _logThread.Start();
        }

        private static void LogMessage(string message, LogLevel level)
        {
            if (level <= Level)
            {
                // Add the log message to the queue instead of invoking immediately
                _logQueue.Enqueue(new LoggerMessageEventArgs { Message = message, Level = level });
            }
        }

        public static void WriteLine(string message, LogLevel level)
        {
            LogMessage(message + Environment.NewLine, level);
        }

        private static void ProcessLogQueue()
        {
            while (_isRunning || !_logQueue.IsEmpty)
            {
                if (_logQueue.TryDequeue(out var logEvent))
                {
                    // Raise the MessageLogged event on the logging thread
                    MessageLogged?.Invoke(null, logEvent);
                }
                else
                {
                    Thread.Sleep(10); // No messages, sleep briefly
                }
            }
        }

        public static void StopLogger()
        {
            _isRunning = false;
            _logThread.Join(); // Ensure the log processing thread shuts down cleanly
        }
    }
}
