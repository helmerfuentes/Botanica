namespace Principal.FormularioJuego
{
    partial class PuntajeDeJuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntajeDeJuegos));
            this.tablaPuntaje = new System.Windows.Forms.DataGridView();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuntaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPuntaje
            // 
            this.tablaPuntaje.AllowUserToAddRows = false;
            this.tablaPuntaje.AllowUserToDeleteRows = false;
            this.tablaPuntaje.BackgroundColor = System.Drawing.Color.LightCyan;
            this.tablaPuntaje.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tablaPuntaje.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaPuntaje.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaPuntaje.Location = new System.Drawing.Point(70, 62);
            this.tablaPuntaje.Name = "tablaPuntaje";
            this.tablaPuntaje.ReadOnly = true;
            this.tablaPuntaje.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaPuntaje.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.tablaPuntaje.Size = new System.Drawing.Size(661, 223);
            this.tablaPuntaje.TabIndex = 0;
            this.tablaPuntaje.VirtualMode = true;
            this.tablaPuntaje.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.tablaPuntaje_RowPrePaint);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.White;
            this.pictureBox17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox17.BackgroundImage")));
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox17.Location = new System.Drawing.Point(378, 12);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(38, 35);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 14;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            // 
            // PuntajeDeJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Principal.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.tablaPuntaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PuntajeDeJuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntajeDeJuegos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuntaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaPuntaje;
        private System.Windows.Forms.PictureBox pictureBox17;
    }
}