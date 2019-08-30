namespace Principal
{
    partial class Antisepticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Antisepticas));
            this.informacion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.transparentControl1 = new TransControl_src.TransparentControl();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.transparentControl1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // informacion
            // 
            this.informacion.BorderColor = System.Drawing.Color.SeaGreen;
            this.informacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.informacion.Enabled = false;
            this.informacion.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacion.ForeColor = System.Drawing.Color.DarkGreen;
            this.informacion.Location = new System.Drawing.Point(0, 0);
            this.informacion.Multiline = true;
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(1052, 112);
            this.informacion.TabIndex = 32;
            this.informacion.Text = resources.GetString("informacion.Text");
            // 
            // transparentControl1
            // 
            this.transparentControl1.Controls.Add(this.groupBox9);
            this.transparentControl1.Controls.Add(this.pictureBox10);
            this.transparentControl1.Location = new System.Drawing.Point(67, 118);
            this.transparentControl1.MinimumSize = new System.Drawing.Size(100, 75);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 0.3D;
            this.transparentControl1.Size = new System.Drawing.Size(677, 560);
            this.transparentControl1.TabIndex = 33;
            this.transparentControl1.Text = "transparentControl1";
            this.transparentControl1.Transparent = true;
            // 
            // groupBox9
            // 
            this.groupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox9.Controls.Add(this.pictureBox9);
            this.groupBox9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(-429, 388);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(227, 153);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Sabila";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(31, 19);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(176, 95);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(-435, 202);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(176, 95);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 6;
            this.pictureBox10.TabStop = false;
            // 
            // Antisepticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 611);
            this.ControlBox = false;
            this.Controls.Add(this.transparentControl1);
            this.Controls.Add(this.informacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Antisepticas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Antisepticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.transparentControl1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox informacion;
        private TransControl_src.TransparentControl transparentControl1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}