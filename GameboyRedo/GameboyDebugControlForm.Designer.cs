namespace GameboyRedo
{
    partial class GameboyDebugControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            clockToolStripMenuItem = new ToolStripMenuItem();
            clockTypeToolStripMenuItem = new ToolStripMenuItem();
            continuousToolStripMenuItem = new ToolStripMenuItem();
            singleTCycleToolStripMenuItem = new ToolStripMenuItem();
            singleMCycleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(505, 59);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Advance 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, clockToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // clockToolStripMenuItem
            // 
            clockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clockTypeToolStripMenuItem });
            clockToolStripMenuItem.Name = "clockToolStripMenuItem";
            clockToolStripMenuItem.Size = new Size(49, 20);
            clockToolStripMenuItem.Text = "Clock";
            // 
            // clockTypeToolStripMenuItem
            // 
            clockTypeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { continuousToolStripMenuItem, singleTCycleToolStripMenuItem, singleMCycleToolStripMenuItem });
            clockTypeToolStripMenuItem.Name = "clockTypeToolStripMenuItem";
            clockTypeToolStripMenuItem.Size = new Size(180, 22);
            clockTypeToolStripMenuItem.Text = "ClockType";
            // 
            // continuousToolStripMenuItem
            // 
            continuousToolStripMenuItem.Name = "continuousToolStripMenuItem";
            continuousToolStripMenuItem.Size = new Size(180, 22);
            continuousToolStripMenuItem.Text = "Continuous";
            continuousToolStripMenuItem.Click += continuousToolStripMenuItem_Click;
            // 
            // singleTCycleToolStripMenuItem
            // 
            singleTCycleToolStripMenuItem.Name = "singleTCycleToolStripMenuItem";
            singleTCycleToolStripMenuItem.Size = new Size(180, 22);
            singleTCycleToolStripMenuItem.Text = "Single T Cycle";
            singleTCycleToolStripMenuItem.Click += singleTCycleToolStripMenuItem_Click;
            // 
            // singleMCycleToolStripMenuItem
            // 
            singleMCycleToolStripMenuItem.Name = "singleMCycleToolStripMenuItem";
            singleMCycleToolStripMenuItem.Size = new Size(180, 22);
            singleMCycleToolStripMenuItem.Text = "Single M Cycle";
            singleMCycleToolStripMenuItem.Click += singleMCycleToolStripMenuItem_Click;
            // 
            // GameboyDebugControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 150);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GameboyDebugControlForm";
            Text = "GameboyDebugControlForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem clockToolStripMenuItem;
        private ToolStripMenuItem clockTypeToolStripMenuItem;
        private ToolStripMenuItem continuousToolStripMenuItem;
        private ToolStripMenuItem singleTCycleToolStripMenuItem;
        private ToolStripMenuItem singleMCycleToolStripMenuItem;
    }
}