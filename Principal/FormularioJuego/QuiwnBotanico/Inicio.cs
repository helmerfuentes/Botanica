using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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
            Pregunta pregunta = new Pregunta(txtnombre.Text,0);
            sonido.Stop();
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MenuJuegos mj = new MenuJuegos();
            mj.Show();
            this.Close();
        }
    }
}
