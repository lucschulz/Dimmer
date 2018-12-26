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
            this.wheel = new System.Windows.Forms.NumericUpDown();
            this.pBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.wheel)).BeginInit();
            this.SuspendLayout();
            // 
            // wheel
            // 
            this.wheel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheel.Location = new System.Drawing.Point(48, 13);
            this.wheel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wheel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.wheel.Name = "wheel";
            this.wheel.Size = new System.Drawing.Size(72, 35);
            this.wheel.TabIndex = 0;
            this.wheel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wheel.ValueChanged += new System.EventHandler(this.wheel_ValueChanged);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 59);
            this.pBar.Maximum = 255;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(144, 23);
            this.pBar.Step = 1;
            this.pBar.TabIndex = 1;
            // 
            // Dimmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(175, 96);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.wheel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dimmer";
            this.Text = "Dimmer";
            ((System.ComponentModel.ISupportInitialize)(this.wheel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown wheel;
        private System.Windows.Forms.ProgressBar pBar;
    }
}

