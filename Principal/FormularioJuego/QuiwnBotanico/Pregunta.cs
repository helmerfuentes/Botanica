using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.FormularioJuego.QuiwnBotanico
{
    public partial class Pregunta : Form
    {
        private int pregunta=-1; 
        public Pregunta(String nombre,int pregunta)
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
                    break;
                case 1:
                    button2.Focus();
                    button2.IdleFillColor = Color.PowderBlue;
                    break;
                case 2:
                    button3.Focus();
                    button3.IdleFillColor = Color.PowderBlue;
                    break;
                case 3:
                    button4.Focus();
                    button4.IdleFillColor = Color.PowderBlue;
                    break;
                case 4:
                    button5.Focus();
                    button5.IdleFillColor = Color.PowderBlue;
                    break;
                case 5:
                    button6.Focus();
                    button6.IdleFillColor = Color.PowderBlue;
                    break;
                case 6:
                    button7.Focus();
                    button7.IdleFillColor = Color.PowderBlue;
                    break;
                case 7:
                    button8.Focus();
                    button8.IdleFillColor = Color.PowderBlue;
                    break;
                case 8:
                    button9.Focus();
                    button9.IdleFillColor = Color.PowderBlue;
                    break;
                case 9:
                    button10.Focus();
                    button10.IdleFillColor = Color.PowderBlue;
                    break; 
                default:
                    MessageBox.Show("error ...");
                    break;
            }
        }
        private void btnresponder_Click(object sender, EventArgs e)
        {
            Repuesta respuesta = new Repuesta(jlbNombre.Text,pregunta);
            this.Close();
        }
    }
}
