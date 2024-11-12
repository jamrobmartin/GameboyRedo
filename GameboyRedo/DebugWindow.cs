﻿namespace GameboyRedo
{
    public partial class DebugWindow : Form
    {
        public DebugWindow()
        {
            InitializeComponent();

            Logger.MessageLogged += Logger_MessageLogged;
        }

        private void Logger_MessageLogged(object? sender, Logger.LoggerMessageEventArgs e)
        {
            try
            {
                if (textBox1.InvokeRequired)
                {
                    Action action = delegate { Logger_MessageLogged(sender, e); };
                    textBox1.Invoke(action);
                }
                else
                {
                    string level = "[" + e.Level + "] ";
                    string msg = e.Message;
                    textBox1.AppendText(msg);
                }
            }
            catch
            {
                // Have to include the try/catch in case the application tries to close mid Invoke
            }
        }


    }
}
