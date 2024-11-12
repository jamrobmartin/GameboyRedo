using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GameboyRedo
{
    public partial class DebugClockControl : UserControl
    {
        public DebugClockControl()
        {
            InitializeComponent();

            Gameboy.Instance.Clock.PropertyChanged += Clock_PropertyChanged;
        }

        private void Clock_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            UpdateButtons();
        }

        private void UpdateButtons()
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.Clock.Play();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.Clock.TogglePause();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.Clock.Stop();
        }

        private void buttonMCycle_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.Clock.ProcessSingleMCycle();
        }

        private void buttonTCycle_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.Clock.ProcessSingleTCycle();
        }
    }
}
