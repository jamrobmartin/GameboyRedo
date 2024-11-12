namespace GameboyRedo
{
    public partial class GameboyDebugControlForm : Form
    {
        public GameboyDebugControlForm()
        {
            InitializeComponent();
        }

        private void continuousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.Clock.ChangeClockType(EClockType.Continuous);
        }

        private void singleTCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.Clock.ChangeClockType(EClockType.SingleTCycle);
        }

        private void singleMCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.Clock.ChangeClockType(EClockType.SingleMCycle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.Clock.DoTick();
        }
    }
}
