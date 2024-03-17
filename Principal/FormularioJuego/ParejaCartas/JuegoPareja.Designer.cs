namespace Principal.FormularioJuego.ParejaCartas
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
			this.jlbRecord = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.jllTiempo = new System.Windows.Forms.Label();
			this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btnPuntaje = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnVolver = new Bunifu.Framework.UI.BunifuFlatButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnReiniciar
			// 
			this.btnReiniciar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnReiniciar.BorderRadius = 0;
			this.btnReiniciar.ButtonText = "Iniciar Juego";
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
			this.btnReiniciar.Location = new System.Drawing.Point(7, 102);
			this.btnReiniciar.Name = "btnReiniciar";
			this.btnReiniciar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnReiniciar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.btnReiniciar.OnHoverTextColor = System.Drawing.Color.White;
			this.btnReiniciar.selected = false;
			this.btnReiniciar.Size = new System.Drawing.Size(153, 38);
			this.btnReiniciar.TabIndex = 2;
			this.btnReiniciar.Text = "Iniciar Juego";
			this.btnReiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnReiniciar.Textcolor = System.Drawing.Color.White;
			this.btnReiniciar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
			// 
			// jlbRecord
			// 
			this.jlbRecord.AutoSize = true;
			this.jlbRecord.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jlbRecord.Location = new System.Drawing.Point(58, 14);
			this.jlbRecord.Name = "jlbRecord";
			this.jlbRecord.Size = new System.Drawing.Size(77, 18);
			this.jlbRecord.TabIndex = 3;
			this.jlbRecord.Text = "Puntaje: 0";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.btnVolver);
			this.panel1.Controls.Add(this.btnPuntaje);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.jllTiempo);
			this.panel1.Controls.Add(this.jlbRecord);
			this.panel1.Controls.Add(this.btnReiniciar);
			this.panel1.Location = new System.Drawing.Point(848, 167);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(168, 300);
			this.panel1.TabIndex = 5;
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.Color.SeaGreen;
			this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtNombre.ForeColor = System.Drawing.Color.White;
			this.txtNombre.HintForeColor = System.Drawing.Color.White;
			this.txtNombre.HintText = "Digite Nombre y Apellido";
			this.txtNombre.isPassword = false;
			this.txtNombre.LineFocusedColor = System.Drawing.Color.SeaGreen;
			this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
			this.txtNombre.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
			this.txtNombre.LineThickness = 3;
			this.txtNombre.Location = new System.Drawing.Point(2, 46);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(161, 33);
			this.txtNombre.TabIndex = 108;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// jllTiempo
			// 
			this.jllTiempo.AutoSize = true;
			this.jllTiempo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jllTiempo.Location = new System.Drawing.Point(33, 265);
			this.jllTiempo.Name = "jllTiempo";
			this.jllTiempo.Size = new System.Drawing.Size(104, 25);
			this.jllTiempo.TabIndex = 39;
			this.jllTiempo.Text = "00:00:00";
			this.jllTiempo.Click += new System.EventHandler(this.jlbMensaje_Click);
			// 
			// layoutPanel
			// 
			this.layoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.layoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.layoutPanel.ColumnCount = 4;
			this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.layoutPanel.Location = new System.Drawing.Point(24, 29);
			this.layoutPanel.Name = "layoutPanel";
			this.layoutPanel.RowCount = 4;
			this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutPanel.Size = new System.Drawing.Size(806, 573);
			this.layoutPanel.TabIndex = 6;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(894, 404);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 13);
			this.bunifuCustomLabel1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 25);
			this.label1.TabIndex = 109;
			this.label1.Text = "Tiempo:";
			// 
			// btnPuntaje
			// 
			this.btnPuntaje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnPuntaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnPuntaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPuntaje.BorderRadius = 0;
			this.btnPuntaje.ButtonText = "Puntajes";
			this.btnPuntaje.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPuntaje.DisabledColor = System.Drawing.Color.Gray;
			this.btnPuntaje.Iconcolor = System.Drawing.Color.Transparent;
			this.btnPuntaje.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPuntaje.Iconimage")));
			this.btnPuntaje.Iconimage_right = null;
			this.btnPuntaje.Iconimage_right_Selected = null;
			this.btnPuntaje.Iconimage_Selected = null;
			this.btnPuntaje.IconMarginLeft = 0;
			this.btnPuntaje.IconMarginRight = 0;
			this.btnPuntaje.IconRightVisible = true;
			this.btnPuntaje.IconRightZoom = 0D;
			this.btnPuntaje.IconVisible = true;
			this.btnPuntaje.IconZoom = 90D;
			this.btnPuntaje.IsTab = false;
			this.btnPuntaje.Location = new System.Drawing.Point(6, 156);
			this.btnPuntaje.Name = "btnPuntaje";
			this.btnPuntaje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnPuntaje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.btnPuntaje.OnHoverTextColor = System.Drawing.Color.White;
			this.btnPuntaje.selected = false;
			this.btnPuntaje.Size = new System.Drawing.Size(153, 38);
			this.btnPuntaje.TabIndex = 110;
			this.btnPuntaje.Text = "Puntajes";
			this.btnPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnPuntaje.Textcolor = System.Drawing.Color.White;
			this.btnPuntaje.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPuntaje.Click += new System.EventHandler(this.btnPuntaje_Click);
			// 
			// btnVolver
			// 
			this.btnVolver.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnVolver.BorderRadius = 0;
			this.btnVolver.ButtonText = "Volver";
			this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVolver.DisabledColor = System.Drawing.Color.Gray;
			this.btnVolver.Iconcolor = System.Drawing.Color.Transparent;
			this.btnVolver.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVolver.Iconimage")));
			this.btnVolver.Iconimage_right = null;
			this.btnVolver.Iconimage_right_Selected = null;
			this.btnVolver.Iconimage_Selected = null;
			this.btnVolver.IconMarginLeft = 0;
			this.btnVolver.IconMarginRight = 0;
			this.btnVolver.IconRightVisible = true;
			this.btnVolver.IconRightZoom = 0D;
			this.btnVolver.IconVisible = true;
			this.btnVolver.IconZoom = 90D;
			this.btnVolver.IsTab = false;
			this.btnVolver.Location = new System.Drawing.Point(7, 199);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnVolver.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.btnVolver.OnHoverTextColor = System.Drawing.Color.White;
			this.btnVolver.selected = false;
			this.btnVolver.Size = new System.Drawing.Size(153, 38);
			this.btnVolver.TabIndex = 111;
			this.btnVolver.Text = "Volver";
			this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnVolver.Textcolor = System.Drawing.Color.White;
			this.btnVolver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// JuegoPareja
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 624);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.layoutPanel);
			this.Controls.Add(this.panel1);
			this.Name = "JuegoPareja";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "JuegoPareja";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnReiniciar;
        private System.Windows.Forms.Label jlbRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label jllTiempo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuFlatButton btnPuntaje;
		private Bunifu.Framework.UI.BunifuFlatButton btnVolver;
	}
}