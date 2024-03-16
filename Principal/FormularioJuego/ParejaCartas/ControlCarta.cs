using Entidades.Helper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Principal.FormularioJuego.ParejaCartas
{
    public partial class ControlCarta : UserControl
    {
        public Image Imagen
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public ControlCarta()
        {
            InitializeComponent();
            // Establecer el DockStyle del ControlCarta
            this.Dock = DockStyle.Fill;

            // Configurar el control PictureBox para no capturar clics
            pictureBox1.Click += (s, e) => OnClick(e);
            pictureBox1.TabStop = false;
            pictureBox1.Dock = DockStyle.Fill;

            // Configurar el control Label para no capturar clics
            //label1.Dock = DockStyle.Fill;

            // Suscribir el evento Click al método ControlCarta_Click
            this.Click += ControlCarta_Click;
        }

        private void ControlCarta_Click(object sender, EventArgs e)
        {
            // Manejar el evento Click aquí
            // Por ejemplo, puedes cambiar el color de fondo del control al hacer clic en él
            //pictureBox1.Image = Imagen;
        }

        public bool SonIguales(ControlCarta otraCarta)
        {
            return ImageHelper.AreEqual(this.Imagen, otraCarta.Imagen);
        }

    }

}
