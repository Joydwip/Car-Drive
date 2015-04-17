namespace UI
{
    partial class CarForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentInfoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.speedButton = new System.Windows.Forms.Button();
            this.speedBox = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Olive;
            this.info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info.Location = new System.Drawing.Point(128, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(41, 13);
            this.info.TabIndex = 5;
            this.info.Text = "CarInfo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.currentInfoLabel);
            this.panel1.Location = new System.Drawing.Point(808, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 48);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Current Speed : ";
            // 
            // currentInfoLabel
            // 
            this.currentInfoLabel.AutoSize = true;
            this.currentInfoLabel.BackColor = System.Drawing.Color.Olive;
            this.currentInfoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentInfoLabel.Location = new System.Drawing.Point(138, 22);
            this.currentInfoLabel.Name = "currentInfoLabel";
            this.currentInfoLabel.Size = new System.Drawing.Size(72, 13);
            this.currentInfoLabel.TabIndex = 21;
            this.currentInfoLabel.Text = "CurrentSpeed";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.info);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 48);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Olive;
            this.panel4.Location = new System.Drawing.Point(391, 280);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 55);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Olive;
            this.panel5.Location = new System.Drawing.Point(391, 382);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 53);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Olive;
            this.panel6.Location = new System.Drawing.Point(391, 324);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(47, 67);
            this.panel6.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Olive;
            this.panel7.Location = new System.Drawing.Point(694, 324);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 67);
            this.panel7.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Olive;
            this.panel8.Location = new System.Drawing.Point(1131, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(38, 619);
            this.panel8.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Olive;
            this.panel9.Location = new System.Drawing.Point(-1, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(38, 619);
            this.panel9.TabIndex = 16;
            // 
            // speedButton
            // 
            this.speedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.speedButton.Location = new System.Drawing.Point(63, 12);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(75, 23);
            this.speedButton.TabIndex = 18;
            this.speedButton.Text = "Save Speed";
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.speedButton_Click_1);
            // 
            // speedBox
            // 
            this.speedBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedBox.Location = new System.Drawing.Point(163, 12);
            this.speedBox.Name = "speedBox";
            this.speedBox.ReadOnly = true;
            this.speedBox.Size = new System.Drawing.Size(120, 20);
            this.speedBox.TabIndex = 17;
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Location = new System.Drawing.Point(37, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopButton.Location = new System.Drawing.Point(152, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 20;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Olive;
            this.panel3.Controls.Add(this.speedButton);
            this.panel3.Controls.Add(this.speedBox);
            this.panel3.Location = new System.Drawing.Point(-1, 659);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 48);
            this.panel3.TabIndex = 24;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Olive;
            this.panel10.Controls.Add(this.startButton);
            this.panel10.Controls.Add(this.stopButton);
            this.panel10.Location = new System.Drawing.Point(762, 659);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(405, 48);
            this.panel10.TabIndex = 23;
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.drawPanel.Location = new System.Drawing.Point(465, 26);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(139, 101);
            this.drawPanel.TabIndex = 25;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1166, 706);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CarForm";
            this.Text = "Drive Car";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CarKey);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentInfoLabel;
        private System.Windows.Forms.Button speedButton;
        private System.Windows.Forms.NumericUpDown speedBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel drawPanel;
    }
}

