namespace Dimmer
{
    partial class Dimmer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dimmer));
			this.tbarMonitorOne = new System.Windows.Forms.TrackBar();
			this.tbarMonitorTwo = new System.Windows.Forms.TrackBar();
			this.lblMonitorOne = new System.Windows.Forms.Label();
			this.lblMonitorTwo = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblMonitorOneValue = new System.Windows.Forms.Label();
			this.lblMonitorTwoValue = new System.Windows.Forms.Label();
			this.btnDimAll = new System.Windows.Forms.Button();
			this.btnMinOne = new System.Windows.Forms.Button();
			this.btnMinTwo = new System.Windows.Forms.Button();
			this.btnMaxTwo = new System.Windows.Forms.Button();
			this.btnMaxOne = new System.Windows.Forms.Button();
			this.sysTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.tbarMonitorOne)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbarMonitorTwo)).BeginInit();
			this.SuspendLayout();
			// 
			// tbarMonitorOne
			// 
			this.tbarMonitorOne.LargeChange = 10;
			this.tbarMonitorOne.Location = new System.Drawing.Point(12, 56);
			this.tbarMonitorOne.Maximum = 255;
			this.tbarMonitorOne.Name = "tbarMonitorOne";
			this.tbarMonitorOne.Size = new System.Drawing.Size(404, 56);
			this.tbarMonitorOne.SmallChange = 5;
			this.tbarMonitorOne.TabIndex = 2;
			this.tbarMonitorOne.Value = 255;
			this.tbarMonitorOne.Scroll += new System.EventHandler(this.TbarMonitorOne_Scroll);
			// 
			// tbarMonitorTwo
			// 
			this.tbarMonitorTwo.LargeChange = 10;
			this.tbarMonitorTwo.Location = new System.Drawing.Point(12, 199);
			this.tbarMonitorTwo.Maximum = 255;
			this.tbarMonitorTwo.Name = "tbarMonitorTwo";
			this.tbarMonitorTwo.Size = new System.Drawing.Size(404, 56);
			this.tbarMonitorTwo.SmallChange = 5;
			this.tbarMonitorTwo.TabIndex = 3;
			this.tbarMonitorTwo.Value = 255;
			this.tbarMonitorTwo.Scroll += new System.EventHandler(this.TbarMonitorTwo_Scroll);
			// 
			// lblMonitorOne
			// 
			this.lblMonitorOne.AutoSize = true;
			this.lblMonitorOne.ForeColor = System.Drawing.Color.Snow;
			this.lblMonitorOne.Location = new System.Drawing.Point(12, 30);
			this.lblMonitorOne.Name = "lblMonitorOne";
			this.lblMonitorOne.Size = new System.Drawing.Size(108, 23);
			this.lblMonitorOne.TabIndex = 4;
			this.lblMonitorOne.Text = "Monitor One";
			// 
			// lblMonitorTwo
			// 
			this.lblMonitorTwo.AutoSize = true;
			this.lblMonitorTwo.ForeColor = System.Drawing.Color.Snow;
			this.lblMonitorTwo.Location = new System.Drawing.Point(12, 173);
			this.lblMonitorTwo.Name = "lblMonitorTwo";
			this.lblMonitorTwo.Size = new System.Drawing.Size(106, 23);
			this.lblMonitorTwo.TabIndex = 5;
			this.lblMonitorTwo.Text = "Monitor Two";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(276, 330);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(140, 36);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// lblMonitorOneValue
			// 
			this.lblMonitorOneValue.AutoSize = true;
			this.lblMonitorOneValue.ForeColor = System.Drawing.Color.Snow;
			this.lblMonitorOneValue.Location = new System.Drawing.Point(392, 30);
			this.lblMonitorOneValue.Name = "lblMonitorOneValue";
			this.lblMonitorOneValue.Size = new System.Drawing.Size(19, 23);
			this.lblMonitorOneValue.TabIndex = 7;
			this.lblMonitorOneValue.Text = "0";
			// 
			// lblMonitorTwoValue
			// 
			this.lblMonitorTwoValue.AutoSize = true;
			this.lblMonitorTwoValue.ForeColor = System.Drawing.Color.Snow;
			this.lblMonitorTwoValue.Location = new System.Drawing.Point(392, 173);
			this.lblMonitorTwoValue.Name = "lblMonitorTwoValue";
			this.lblMonitorTwoValue.Size = new System.Drawing.Size(19, 23);
			this.lblMonitorTwoValue.TabIndex = 8;
			this.lblMonitorTwoValue.Text = "0";
			// 
			// btnDimAll
			// 
			this.btnDimAll.Location = new System.Drawing.Point(16, 330);
			this.btnDimAll.Name = "btnDimAll";
			this.btnDimAll.Size = new System.Drawing.Size(140, 36);
			this.btnDimAll.TabIndex = 9;
			this.btnDimAll.Text = "Minimum Both";
			this.btnDimAll.UseVisualStyleBackColor = true;
			this.btnDimAll.Click += new System.EventHandler(this.BtnDimAll_Click);
			// 
			// btnMinOne
			// 
			this.btnMinOne.Location = new System.Drawing.Point(16, 100);
			this.btnMinOne.Name = "btnMinOne";
			this.btnMinOne.Size = new System.Drawing.Size(50, 36);
			this.btnMinOne.TabIndex = 10;
			this.btnMinOne.Text = "Min";
			this.btnMinOne.UseVisualStyleBackColor = true;
			this.btnMinOne.Click += new System.EventHandler(this.BtnMinOne_Click);
			// 
			// btnMinTwo
			// 
			this.btnMinTwo.Location = new System.Drawing.Point(16, 243);
			this.btnMinTwo.Name = "btnMinTwo";
			this.btnMinTwo.Size = new System.Drawing.Size(50, 36);
			this.btnMinTwo.TabIndex = 11;
			this.btnMinTwo.Text = "Min";
			this.btnMinTwo.UseVisualStyleBackColor = true;
			this.btnMinTwo.Click += new System.EventHandler(this.BtnMinTwo_Click);
			// 
			// btnMaxTwo
			// 
			this.btnMaxTwo.Location = new System.Drawing.Point(361, 243);
			this.btnMaxTwo.Name = "btnMaxTwo";
			this.btnMaxTwo.Size = new System.Drawing.Size(50, 36);
			this.btnMaxTwo.TabIndex = 13;
			this.btnMaxTwo.Text = "Max";
			this.btnMaxTwo.UseVisualStyleBackColor = true;
			this.btnMaxTwo.Click += new System.EventHandler(this.BtnMaxTwo_Click);
			// 
			// btnMaxOne
			// 
			this.btnMaxOne.Location = new System.Drawing.Point(361, 100);
			this.btnMaxOne.Name = "btnMaxOne";
			this.btnMaxOne.Size = new System.Drawing.Size(50, 36);
			this.btnMaxOne.TabIndex = 12;
			this.btnMaxOne.Text = "Max";
			this.btnMaxOne.UseVisualStyleBackColor = true;
			this.btnMaxOne.Click += new System.EventHandler(this.BtnMaxOne_Click);
			// 
			// sysTrayIcon
			// 
			this.sysTrayIcon.BalloonTipText = "Dimmer";
			this.sysTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("sysTrayIcon.Icon")));
			this.sysTrayIcon.Visible = true;
			this.sysTrayIcon.Click += new System.EventHandler(this.SysTrayIcon_Click);
			// 
			// Dimmer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(429, 378);
			this.Controls.Add(this.btnMaxTwo);
			this.Controls.Add(this.btnMaxOne);
			this.Controls.Add(this.btnMinTwo);
			this.Controls.Add(this.btnMinOne);
			this.Controls.Add(this.btnDimAll);
			this.Controls.Add(this.lblMonitorTwoValue);
			this.Controls.Add(this.lblMonitorOneValue);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblMonitorTwo);
			this.Controls.Add(this.lblMonitorOne);
			this.Controls.Add(this.tbarMonitorTwo);
			this.Controls.Add(this.tbarMonitorOne);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "Dimmer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dimmer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dimmer_FormClosing);
			this.Resize += new System.EventHandler(this.Dimmer_Resize);
			((System.ComponentModel.ISupportInitialize)(this.tbarMonitorOne)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbarMonitorTwo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar tbarMonitorOne;
		private System.Windows.Forms.TrackBar tbarMonitorTwo;
		private System.Windows.Forms.Label lblMonitorOne;
		private System.Windows.Forms.Label lblMonitorTwo;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblMonitorOneValue;
		private System.Windows.Forms.Label lblMonitorTwoValue;
		private System.Windows.Forms.Button btnDimAll;
		private System.Windows.Forms.Button btnMinOne;
		private System.Windows.Forms.Button btnMinTwo;
		private System.Windows.Forms.Button btnMaxTwo;
		private System.Windows.Forms.Button btnMaxOne;
		private System.Windows.Forms.NotifyIcon sysTrayIcon;
	}
}

