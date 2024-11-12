using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameboyRedo
{
    public partial class DebugPowerControl : UserControl
    {
        public DebugPowerControl()
        {
            InitializeComponent();
            Gameboy.Instance.PropertyChanged += Instance_PropertyChanged;
        }

        private void Instance_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            string? PropertyName = e.PropertyName;
            if(!string.IsNullOrEmpty(PropertyName)) 
            {
                if(e.PropertyName == "Powered")
                {
                    string power = Gameboy.Instance.Powered ? "On" : "Off";
                    SetPoweredText(power);
                }
            }
        }

        private void SetPoweredText(string power)
        {
            if (textBox1.InvokeRequired)
            {
                // If Invoke is required, use Invoke to marshal the call to the UI thread
                textBox1.Invoke(new Action(() => textBox1.Text = power));
            }
            else
            {
                // Otherwise, directly set the text
                textBox1.Text = power;
            }
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.PowerOn();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.PowerOff();
        }
    }
}
