namespace GameboyRedo
{
    partial class DebugPowerControl
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
            label1 = new Label();
            textBox1 = new TextBox();
            buttonOn = new Button();
            buttonOff = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonOff);
            groupBox1.Controls.Add(buttonOn);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(149, 190);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Power Control";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 0;
            label1.Text = "Power:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(90, 16);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(53, 36);
            textBox1.TabIndex = 1;
            textBox1.Text = "Off";
            // 
            // buttonOn
            // 
            buttonOn.Font = new Font("Segoe UI", 16F);
            buttonOn.Location = new Point(6, 58);
            buttonOn.Name = "buttonOn";
            buttonOn.Size = new Size(137, 60);
            buttonOn.TabIndex = 2;
            buttonOn.Text = "Turn On";
            buttonOn.UseVisualStyleBackColor = true;
            buttonOn.Click += buttonOn_Click;
            // 
            // buttonOff
            // 
            buttonOff.Font = new Font("Segoe UI", 16F);
            buttonOff.Location = new Point(6, 124);
            buttonOff.Name = "buttonOff";
            buttonOff.Size = new Size(137, 60);
            buttonOff.TabIndex = 3;
            buttonOff.Text = "Turn Off";
            buttonOff.UseVisualStyleBackColor = true;
            buttonOff.Click += buttonOff_Click;
            // 
            // DebugPowerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox1);
            Name = "DebugPowerControl";
            Size = new Size(155, 196);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonOff;
        private Button buttonOn;
        private TextBox textBox1;
        private Label label1;
    }
}
