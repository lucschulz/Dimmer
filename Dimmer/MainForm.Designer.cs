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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dimmer));
			this.tbarMonitorOne = new System.Windows.Forms.TrackBar();
			this.tbarMonitorTwo = new System.Windows.Forms.TrackBar();
			this.lblMonitorOne = new System.Windows.Forms.Label();
			this.lblMonitorTwo = new System.Windows.Forms.Label();
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
			this.tbarMonitorOne.Scroll += new System.EventHandler(this.Tbar_Scroll);
			// 
			// tbarMonitorTwo
			// 
			this.tbarMonitorTwo.LargeChange = 10;
			this.tbarMonitorTwo.Location = new System.Drawing.Point(12, 165);
			this.tbarMonitorTwo.Maximum = 255;
			this.tbarMonitorTwo.Name = "tbarMonitorTwo";
			this.tbarMonitorTwo.Size = new System.Drawing.Size(404, 56);
			this.tbarMonitorTwo.SmallChange = 5;
			this.tbarMonitorTwo.TabIndex = 3;
			this.tbarMonitorTwo.Value = 255;
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
			this.lblMonitorTwo.Location = new System.Drawing.Point(12, 139);
			this.lblMonitorTwo.Name = "lblMonitorTwo";
			this.lblMonitorTwo.Size = new System.Drawing.Size(106, 23);
			this.lblMonitorTwo.TabIndex = 5;
			this.lblMonitorTwo.Text = "Monitor Two";
			// 
			// Dimmer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(428, 233);
			this.Controls.Add(this.lblMonitorTwo);
			this.Controls.Add(this.lblMonitorOne);
			this.Controls.Add(this.tbarMonitorTwo);
			this.Controls.Add(this.tbarMonitorOne);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dimmer";
			this.Text = "Dimmer";
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
	}
}

