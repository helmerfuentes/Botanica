namespace Principal.FormularioJuego
{
    partial class JuegoPareja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoPareja));
            this.btnReiniciar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.jlbRecord = new System.Windows.Forms.Label();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReiniciar.BorderRadius = 0;
            this.btnReiniciar.ButtonText = "Reiniciar Juego";
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.DisabledColor = System.Drawing.Color.Gray;
            this.btnReiniciar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReiniciar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.Iconimage")));
            this.btnReiniciar.Iconimage_right = null;
            this.btnReiniciar.Iconimage_right_Selected = null;
            this.btnReiniciar.Iconimage_Selected = null;
            this.btnReiniciar.IconMarginLeft = 0;
            this.btnReiniciar.IconMarginRight = 0;
            this.btnReiniciar.IconRightVisible = true;
            this.btnReiniciar.IconRightZoom = 0D;
            this.btnReiniciar.IconVisible = true;
            this.btnReiniciar.IconZoom = 90D;
            this.btnReiniciar.IsTab = false;
            this.btnReiniciar.Location = new System.Drawing.Point(39, 95);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReiniciar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReiniciar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReiniciar.selected = false;
            this.btnReiniciar.Size = new System.Drawing.Size(153, 38);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar Juego";
            this.btnReiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReiniciar.Textcolor = System.Drawing.Color.White;
            this.btnReiniciar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // jlbRecord
            // 
            this.jlbRecord.AutoSize = true;
            this.jlbRecord.Location = new System.Drawing.Point(98, 18);
            this.jlbRecord.Name = "jlbRecord";
            this.jlbRecord.Size = new System.Drawing.Size(13, 13);
            this.jlbRecord.TabIndex = 3;
            this.jlbRecord.Text = "0";
            // 
            // panelJuego
            // 
            this.panelJuego.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelJuego.Location = new System.Drawing.Point(50, 55);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(509, 432);
            this.panelJuego.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bunifuDropdown1);
            this.panel1.Controls.Add(this.jlbRecord);
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Location = new System.Drawing.Point(585, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 165);
            this.panel1.TabIndex = 5;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(28, 45);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(170, 35);
            this.bunifuDropdown1.TabIndex = 6;
            // 
            // JuegoPareja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelJuego);
            this.Name = "JuegoPareja";
            this.Text = "JuegoPareja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnReiniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label jlbRecord;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
    }
}