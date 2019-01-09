namespace Principal
{
    partial class Astringentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Astringentes));
            this.transparentControl1 = new TransControl_src.TransparentControl();
            this.SuspendLayout();
            // 
            // transparentControl1
            // 
            this.transparentControl1.Location = new System.Drawing.Point(85, 106);
            this.transparentControl1.MinimumSize = new System.Drawing.Size(100, 75);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 0.1D;
            this.transparentControl1.Size = new System.Drawing.Size(350, 149);
            this.transparentControl1.TabIndex = 0;
            this.transparentControl1.Text = "transparentControl1";
            this.transparentControl1.Transparent = true;
            // 
            // Astringentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transparentControl1);
            this.Name = "Astringentes";
            this.Text = "Astringentes";
            this.ResumeLayout(false);

        }

        #endregion

        private TransControl_src.TransparentControl transparentControl1;
    }
}