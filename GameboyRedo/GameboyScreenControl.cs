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
    public partial class GameboyScreenControl : UserControl
    {
        private const int DefaultWidth = 160;
        private const int DefaultHeight = 144;

        private int Scale = 4;


        public GameboyScreenControl()
        {
            InitializeComponent();
            SetSize();
        }

        public void SetSize()
        {
            this.Size = new Size(DefaultWidth * Scale, DefaultHeight * Scale);
        }
    }
}
