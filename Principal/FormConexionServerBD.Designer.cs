namespace Principal
{
    partial class FormConexionServerBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConexionServerBD));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.informacion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtServidor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPuerto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(676, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(714, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 104;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // informacion
            // 
            this.informacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informacion.BorderColor = System.Drawing.Color.SeaGreen;
            this.informacion.Enabled = false;
            this.informacion.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacion.ForeColor = System.Drawing.Color.DarkGreen;
            this.informacion.Location = new System.Drawing.Point(103, 72);
            this.informacion.Multiline = true;
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(596, 128);
            this.informacion.TabIndex = 106;
            this.informacion.Text = resources.GetString("informacion.Text");
            this.informacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServidor
            // 
            this.txtServidor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtServidor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServidor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtServidor.ForeColor = System.Drawing.Color.White;
            this.txtServidor.HintForeColor = System.Drawing.Color.Empty;
            this.txtServidor.HintText = "Digite Servidor";
            this.txtServidor.isPassword = false;
            this.txtServidor.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtServidor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtServidor.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtServidor.LineThickness = 3;
            this.txtServidor.Location = new System.Drawing.Point(182, 229);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(4);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(271, 33);
            this.txtServidor.TabIndex = 107;
            this.txtServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPuerto
            // 
            this.txtPuerto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtPuerto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPuerto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPuerto.ForeColor = System.Drawing.Color.White;
            this.txtPuerto.HintForeColor = System.Drawing.Color.Empty;
            this.txtPuerto.HintText = "Puerto";
            this.txtPuerto.isPassword = false;
            this.txtPuerto.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtPuerto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPuerto.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtPuerto.LineThickness = 3;
            this.txtPuerto.Location = new System.Drawing.Point(460, 229);
            this.txtPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(156, 33);
            this.txtPuerto.TabIndex = 108;
            this.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "Usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(142, 281);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(271, 33);
            this.txtUsuario.TabIndex = 109;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Contraseña";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(421, 281);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 33);
            this.txtPassword.TabIndex = 110;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.Location = new System.Drawing.Point(339, 352);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(114, 37);
            this.btnValidar.TabIndex = 111;
            this.btnValidar.Text = "Validar";
            this.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // FormConexionServerBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Principal.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConexionServerBD";
            this.Text = "FormConexionServerBD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox informacion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtServidor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPuerto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.Button btnValidar;
    }
}