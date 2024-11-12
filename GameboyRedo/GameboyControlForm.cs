namespace GameboyRedo
{
    public partial class GameboyControlForm : Form
    {
        public GameboyControlForm()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.PowerOn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gameboy.Instance.PowerOff();
        }

        private void GameboyControlForm_Load(object sender, EventArgs e)
        {
            gameboyScreenControl1.SetSize();

            Gameboy.Instance.Initialize();
        }

        private void selectROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // File Selector
        }

        private void runROMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugWindow debugWindow = new DebugWindow();
            debugWindow.Show();
            debugWindow.Location = new Point(this.Width, 0);
        }
    }
}
