using System;
using System.Media;
using System.Windows.Forms;

namespace Principal.FormularioJuego.QuiwnBotanico
{
    public partial class Inicio : Form
    {
        SoundPlayer sonido;
        public Inicio()
        {
            InitializeComponent();
            this.Visible = true;
            inicio();
        }
        private void inicio()
        {
            try
            {
                sonido = new SoundPlayer(Application.StartupPath + @".\m_inicio.wav");
                sonido.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Digite Nombre y Apellido" || txtnombre.Text == string.Empty)
            {
                MessageBox.Show("Ingresar nombre y apellido", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Pregunta pregunta = new Pregunta(txtnombre.Text, 0);
                sonido.Stop();
                this.Close();
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MenuJuegos mj = new MenuJuegos();
            sonido.Stop();
            mj.Show();
            this.Close();
        }

        private void btnPuntaje_Click(object sender, EventArgs e)
        {
            PuntajeDeJuegos puntaje = new PuntajeDeJuegos(Entidades.Enums.TiposDeJuegoEnum.Botanico);
            puntaje.ShowDialog();
        }
    }
}
