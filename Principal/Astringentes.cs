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
    public partial class Astringentes : Form
    {
        public Astringentes()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void foto1_Click(object sender, EventArgs e)
        {
            String N1 = "Acetaminafen";
            String N2 = "Plectranthus ornatus Codd";
            String foto = "AcetaminafenH.jpeg";
            String texto = "Es una hierba muy útil, particularmente para el sistema digestivo| \n Conozca las propiedades del boldo, conocido como 'hojas de acetaminofén'\n Plectranthus ornatus Codd";

            CargarClick(foto,texto,N1,N2);
        }

        private void CargarClick(String foto, String texto, String n , String nc)
        {
            NComun.Text = n;
            NCientifico.Text = nc;
            TDato.Text = texto;
            Foto.Load(@"C:\Users\WILL\Desktop\C#\Botanica\Principal\plantas pozo\" + foto);
        }

        private void Foto2_Click(object sender, EventArgs e)
        {
            String N1 = "Albaca";
            String N2 = "Ocimum basilicum";
            String foto = "AlbacaH.jpeg";
            String texto = "Su consumo ayuda a aliviar los gases intestinales, los dolores de estómago, las flatulencias y las indigestiones.\n Las hojas y elaceite de albahaca tienen propiedades antibacterianas, por lo que son muy efectivas para fortalecer el\n sistema inmunológico y combatir infecciones en el organismo.";

            CargarClick(foto, texto, N1, N2);
        }

        private void Foto3_Click(object sender, EventArgs e)
        {
            String N1 = "Alivia Dolor";
            String N2 = "Harpagofito";
            String foto = "Alivia DolorH.jpeg";
            String texto = "Utiliza para aliviar los dolores lumbares(combinado con sauce blanco) y los calambres musculares. \n Es preferible usarla en tintura.Mezcla con harpagofito para las articulaciones y miembros hinchados.\n Efectiva hierba antiinflamatoria aconsejada para el tratamiento del dolor articular y la artritis.";

            CargarClick(foto, texto, N1, N2);            
        }

        private void Foto4_Click(object sender, EventArgs e)
        {
            String N1 = "Anamu";
            String N2 = "Petiveria Alliacea";
            String foto = "AnamuH.jpeg";
            String texto = "El anamú es una planta con reconocidas propiedades antiinflamatorias, útil en múltiples padecimientos \n tales como la artritis, ayudando a reducir la inflamación en las articulaciones que normalmente acompaña a esta enfermedad,\n además, puede ejercer efecto analgésico disminuyendo el dolor.";

            CargarClick(foto, texto, N1, N2);
        }

        private void Foto5_Click(object sender, EventArgs e)
        {
            String N1 = "Anjeo";
            String N2 = "Artemisia absinthium";
            String foto = "AnjeoH.jpeg";
            String texto = "Es perfecto para el tratamiento de afecciones como la indigestión, gases y la eliminación de parásitos intestinales.\n  También se ha usado el ajenjo como un ayudante en problemas del hígado y vesícula.\n  Aumenta la secreción de jugos biliares descongestionando el hígado y mejorando sus funciones.";

            CargarClick(foto, texto, N1, N2);
        }

        private void Foto6_Click(object sender, EventArgs e)
        {
            String N1 = "Altamisa";
            String N2 = "Chrysanthemum parthenium";
            String foto = "AntamisaH.jpeg";
            String texto = "La altamisa ha sido usada comúnmente para reducir la fiebre, dolores de cabeza, migraña, artritis y problemas digestivos.\n  Es un inhibidor natural de la serotonina y prostaglandinas, a las cuales se les considera causantes de la migraña,\n  la altamisa evita la inflamación de los vasos sanguíneos del cerebro, deteniendo los espasmos de los vasos, lo cual,\n  se cree, contribuye a los dolores de cabeza. Los ingredientes activos en la altamisa son Partenolida y Tanetina,\n  los cuales alivian los síntomas de la migraña.";

            CargarClick(foto, texto, N1, N2);
        }

        private void Foto7_Click(object sender, EventArgs e)
        {

        }
    }
}
