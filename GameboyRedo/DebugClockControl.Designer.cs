namespace GameboyRedo
{
    partial class DebugClockControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            buttonStop = new Button();
            buttonPause = new Button();
            buttonTCycle = new Button();
            buttonMCycle = new Button();
            buttonPlay = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonStop);
            groupBox1.Controls.Add(buttonPause);
            groupBox1.Controls.Add(buttonTCycle);
            groupBox1.Controls.Add(buttonMCycle);
            groupBox1.Controls.Add(buttonPlay);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clock Control";
            // 
            // buttonStop
            // 
            buttonStop.Font = new Font("Segoe UI", 16F);
            buttonStop.Location = new Point(258, 22);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(120, 60);
            buttonStop.TabIndex = 4;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonPause
            // 
            buttonPause.Font = new Font("Segoe UI", 16F);
            buttonPause.Location = new Point(132, 22);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(120, 60);
            buttonPause.TabIndex = 3;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonTCycle
            // 
            buttonTCycle.Font = new Font("Segoe UI", 16F);
            buttonTCycle.Location = new Point(6, 159);
            buttonTCycle.Name = "buttonTCycle";
            buttonTCycle.Size = new Size(372, 65);
            buttonTCycle.TabIndex = 2;
            buttonTCycle.Text = "T Cycle Step";
            buttonTCycle.UseVisualStyleBackColor = true;
            buttonTCycle.Click += buttonTCycle_Click;
            // 
            // buttonMCycle
            // 
            buttonMCycle.Font = new Font("Segoe UI", 16F);
            buttonMCycle.Location = new Point(6, 88);
            buttonMCycle.Name = "buttonMCycle";
            buttonMCycle.Size = new Size(372, 65);
            buttonMCycle.TabIndex = 1;
            buttonMCycle.Text = "M Cycle Step";
            buttonMCycle.UseVisualStyleBackColor = true;
            buttonMCycle.Click += buttonMCycle_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.Font = new Font("Segoe UI", 16F);
            buttonPlay.Location = new Point(6, 22);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(120, 60);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // DebugClockControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox1);
            Name = "DebugClockControl";
            Size = new Size(390, 237);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonPause;
        private Button buttonTCycle;
        private Button buttonMCycle;
        private Button buttonPlay;
        private Button buttonStop;
    }
}
