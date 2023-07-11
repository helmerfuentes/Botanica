namespace Principal
{
    partial class plantaItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.txtnombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pctImagen
            // 
            this.pctImagen.Location = new System.Drawing.Point(1, 39);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(166, 135);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagen.TabIndex = 0;
            this.pctImagen.TabStop = false;
            this.pctImagen.Click += new System.EventHandler(this.pctImagen_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtnombre.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtnombre.Location = new System.Drawing.Point(3, 4);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnombre.Size = new System.Drawing.Size(168, 29);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.Text = "sd sds ds d sd sd sd sd";
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plantaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.pctImagen);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "plantaItem";
            this.Size = new System.Drawing.Size(167, 175);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImagen;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtnombre;
    }
}
