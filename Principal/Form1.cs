using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {

        String ultima;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnastringes_MouseClick(object sender, MouseEventArgs e)
        {

          
            MessageBox.Show("");

        }

        private void btnastringes_Click_1(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuThinButton2 cerrar = sender as Bunifu.Framework.UI.BunifuThinButton2;
         

            informacionmostrar(cerrar.Name);

        }

        public void informacionmostrar(String boton)
        {
            informacion.Text = "";
            switch (boton)
            {
                case "b1":
                    informacion.Text = "Astringentes. Son aquellas que contraen los tejidos, combatiendo inflamaciones de la boca, la garganta, los intestinos y los órganos genitales.";
                 break;
                case "b2":
                    informacion.Text = "Antisépticas. Son plantas desinfectantes.";
                 break;
                case "b3":
                    informacion.Text = "Apetentes. Abren el apetito.";
                 break;
                case "b4":
                    informacion.Text = "Béquicas. Sirven para combatir la tos.";
                 break;
                case "b5":
                    informacion.Text = "Calmantes o sedativas. Ayudan a calmar el sistema nervioso.";
                 break;
                case "b6":
                    informacion.Text = "Carminativas. Son aquellas que combaten la flatulencia estomacal e intestinal.";
                 break;
                case "b7":
                    informacion.Text = "Depurativas. Sirven para purificar y limpiar la sangre.";
                 break;
                case "b8":
                    informacion.Text = "Desobtruyentes. Sirven para las obstrucciones estomacales y hepáticas.";
                 break;
                case "b9":
                    informacion.Text = "Diuréticas. Sirven para aumentar la orina";
                 break;
                case "b10":
                    informacion.Text = "Emenágogas. Útil para provocar o restablecer la menstruación.";
                 break;
                case "b11":
                    informacion.Text = "Eméticas. Ayudan a provocar vómitos en caso de ser necesario, como en las intoxicaciones.";
                 break;
                case "b12":
                    informacion.Text = "Emolientes. Ablandan el tejido endurecido de los abscesos, ulceras e inflamaciones.";
                 break;
                case "b13":
                    informacion.Text = "Estimulantes. Sirven para aumentar la energía del cuerpo.";
                 break;
                case "b14":
                    informacion.Text = "Estomacales. Alivian el malestar estomacal.";
                 break;
                case "b15":
                    informacion.Text = "Expectorantes o pectorales. Sirven para despejar las vías respiratorias y ayudan a expulsar el catarro.";
                 break;
                case "b16":
                    informacion.Text = "Febrífugas. Son buenas para combatir la fiebre.";
                 break;
                case "b17":
                    informacion.Text = "Hemostáticas. Son aquellas que combaten las hemorragias.";
                 break;
                case "b18":
                    informacion.Text = "Purgantes o laxantes. Sirven para provocar o acelerar las evacuaciones.";
                 break;
                case "b19":
                    informacion.Text = "Resolutivas. Ayudan a acabar las inflamaciones.";
                 break;
                case "b20":
                    informacion.Text = "Sudoríficas. Causan la sudoración o transpiración.";
                 break;
                case "b21":
                    informacion.Text = "Tónicas. Son buenas para fortificar el cuerpo, combatir la anemia y la debilidad pulmonar.";
                 break;
                case "b22":
                    informacion.Text = "Vermífugas o antihelmínticas. Sirven para exterminar las lombrices.";
                 break;
                case "b23":
                    informacion.Text = "Vulnerarias. Son aquellas plantas importantes que ayudan a curar heridas.";
                 break;
                case "b24":
                    informacion.Text = "Estimulo los Visto en los Modulos Anteriores";
                 break;
            }

        }
    }
}
