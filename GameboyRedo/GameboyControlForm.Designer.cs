namespace GameboyRedo
{
    partial class GameboyControlForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            selectROMToolStripMenuItem = new ToolStripMenuItem();
            emulatorToolStripMenuItem = new ToolStripMenuItem();
            runROMToolStripMenuItem = new ToolStripMenuItem();
            runDebugToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            scaleUpToolStripMenuItem = new ToolStripMenuItem();
            scaleDownToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            gameboyScreenControl1 = new GameboyScreenControl();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, emulatorToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(1769, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectROMToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // selectROMToolStripMenuItem
            // 
            selectROMToolStripMenuItem.Name = "selectROMToolStripMenuItem";
            selectROMToolStripMenuItem.Size = new Size(135, 22);
            selectROMToolStripMenuItem.Text = "Select ROM";
            selectROMToolStripMenuItem.Click += selectROMToolStripMenuItem_Click;
            // 
            // emulatorToolStripMenuItem
            // 
            emulatorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runROMToolStripMenuItem, runDebugToolStripMenuItem });
            emulatorToolStripMenuItem.Name = "emulatorToolStripMenuItem";
            emulatorToolStripMenuItem.Size = new Size(67, 24);
            emulatorToolStripMenuItem.Text = "Emulator";
            // 
            // runROMToolStripMenuItem
            // 
            runROMToolStripMenuItem.Name = "runROMToolStripMenuItem";
            runROMToolStripMenuItem.Size = new Size(171, 22);
            runROMToolStripMenuItem.Text = "Run ROM";
            runROMToolStripMenuItem.Click += runROMToolStripMenuItem_Click;
            // 
            // runDebugToolStripMenuItem
            // 
            runDebugToolStripMenuItem.Name = "runDebugToolStripMenuItem";
            runDebugToolStripMenuItem.Size = new Size(171, 22);
            runDebugToolStripMenuItem.Text = "Run ROM - Debug";
            runDebugToolStripMenuItem.Click += runDebugToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scaleUpToolStripMenuItem, scaleDownToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(101, 22);
            zoomToolStripMenuItem.Text = "Scale";
            // 
            // scaleUpToolStripMenuItem
            // 
            scaleUpToolStripMenuItem.Name = "scaleUpToolStripMenuItem";
            scaleUpToolStripMenuItem.Size = new Size(135, 22);
            scaleUpToolStripMenuItem.Text = "Scale Up";
            // 
            // scaleDownToolStripMenuItem
            // 
            scaleDownToolStripMenuItem.Name = "scaleDownToolStripMenuItem";
            scaleDownToolStripMenuItem.Size = new Size(135, 22);
            scaleDownToolStripMenuItem.Text = "Scale Down";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 941);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1769, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(41, 17);
            toolStripStatusLabel1.Text = "Game:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(96, 17);
            toolStripStatusLabel2.Text = "Nothing Inserted";
            // 
            // gameboyScreenControl1
            // 
            gameboyScreenControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gameboyScreenControl1.Location = new Point(0, 0);
            gameboyScreenControl1.Margin = new Padding(0);
            gameboyScreenControl1.Name = "gameboyScreenControl1";
            gameboyScreenControl1.Size = new Size(66, 51);
            gameboyScreenControl1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(gameboyScreenControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1769, 917);
            panel1.TabIndex = 3;
            // 
            // GameboyControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1769, 963);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GameboyControlForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += GameboyControlForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem selectROMToolStripMenuItem;
        private ToolStripMenuItem emulatorToolStripMenuItem;
        private ToolStripMenuItem runROMToolStripMenuItem;
        private ToolStripMenuItem runDebugToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem scaleUpToolStripMenuItem;
        private ToolStripMenuItem scaleDownToolStripMenuItem;
        private GameboyScreenControl gameboyScreenControl1;
        private Panel panel1;
    }
}
