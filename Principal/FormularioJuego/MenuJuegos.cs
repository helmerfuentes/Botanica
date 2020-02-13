using Principal.FormularioJuego.QuiwnBotanico;
using System;
using System.Windows.Forms;

namespace Principal.FormularioJuego
{
    public partial class MenuJuegos : Form
    {
        public MenuJuegos()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormularioJuego._1Vs1 _1Vs1 = new _1Vs1();
            _1Vs1.Show();
            this.Close();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormularioJuego.JuegoPareja juegoPareja = new JuegoPareja();
            juegoPareja.Show();
            this.Close();
        }
    }
}
