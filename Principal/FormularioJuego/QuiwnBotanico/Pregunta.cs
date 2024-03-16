using Dato;
using Entidades.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Principal.FormularioJuego.QuiwnBotanico
{
    public partial class Pregunta : Form
    {
        private int pregunta = -1;
        private string puntaje = string.Empty;
        public Pregunta(String nombre, int pregunta)
        {
            InitializeComponent();
            this.Visible = true;
            this.pregunta = pregunta;
            jlbNombre.Text = nombre;
            cargar();
        }


        private void cargar()
        {
            switch (pregunta)
            {
                case 0:
                    button1.Focus();
                    button1.IdleFillColor = Color.PowderBlue;
                    puntaje = button1.ButtonText;
                    break;
                case 1:
                    button2.Focus();
                    button2.IdleFillColor = Color.PowderBlue;
                    puntaje = button2.ButtonText;
                    break;
                case 2:
                    button3.Focus();
                    button3.IdleFillColor = Color.PowderBlue;
                    puntaje = button3.ButtonText;
                    break;
                case 3:
                    button4.Focus();
                    button4.IdleFillColor = Color.PowderBlue;
                    puntaje = button4.ButtonText;
                    break;
                case 4:
                    button5.Focus();
                    button5.IdleFillColor = Color.PowderBlue;
                    puntaje = button5.ButtonText;
                    break;
                case 5:
                    button6.Focus();
                    button6.IdleFillColor = Color.PowderBlue;
                    puntaje = button6.ButtonText;
                    break;
                case 6:
                    button7.Focus();
                    button7.IdleFillColor = Color.PowderBlue;
                    puntaje = button7.ButtonText;
                    break;
                case 7:
                    button8.Focus();
                    button8.IdleFillColor = Color.PowderBlue;
                    puntaje = button8.ButtonText;
                    break;
                case 8:
                    button9.Focus();
                    button9.IdleFillColor = Color.PowderBlue;
                    puntaje = button9.ButtonText;
                    break;
                case 9:
                    button10.Focus();
                    button10.IdleFillColor = Color.PowderBlue;
                    puntaje = button10.ButtonText;
                    break;
                default:
                    var puntajeDatos = new PuntajeDatos();
                    puntajeDatos.GuardarPuntaje(jlbNombre.Text, this.puntaje, TiposDeJuegoEnum.Botanico);
                    panel4.BackgroundImage = Properties.Resources.winnerBotanico;
                    MessageBox.Show("Ganastes, eres un botanico");
                    break;
            }
        }
        private void btnresponder_Click(object sender, EventArgs e)
        {
            Repuesta respuesta = new Repuesta(jlbNombre.Text, pregunta, puntaje);
            this.Close();
        }
    }
}
