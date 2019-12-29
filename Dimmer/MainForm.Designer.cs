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
            this.tbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbar
            // 
            this.tbar.LargeChange = 10;
            this.tbar.Location = new System.Drawing.Point(12, 12);
            this.tbar.Maximum = 255;
            this.tbar.Name = "tbar";
            this.tbar.Size = new System.Drawing.Size(154, 45);
            this.tbar.SmallChange = 5;
            this.tbar.TabIndex = 2;
            this.tbar.Value = 255;
            this.tbar.Scroll += new System.EventHandler(this.Tbar_Scroll);
            // 
            // Dimmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(178, 61);
            this.Controls.Add(this.tbar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dimmer";
            this.Text = "Dimmer";
            ((System.ComponentModel.ISupportInitialize)(this.tbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar tbar;
    }
}

