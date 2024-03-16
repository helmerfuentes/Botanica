using Entidades;
using logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Principal
{
    public partial class VistaGeneral : Form
    {
        List<PlantaModel> plantas;
        LogicaPlanta LogicaPlanta;
        List<Image> ListaImagenesPlanta;
        int indiceImagenListaPlanta = 0;
        int indicePlantaLista;
        public VistaGeneral(string idTipoPlanta)
        {
            InitializeComponent();
            LogicaPlanta = new LogicaPlanta();
            CargarImagenes(idTipoPlanta);
        }

        private void CargarImagenes(string tipo)
        {
            plantas = LogicaPlanta.ObtenerPlantasTipo(tipo);
            if (plantas != null && plantas.Count > 0)
            {
                informacion.Text = plantas[0].TipoPlanta[0].Descripcion;
                plantaItem[] plantaItems = new plantaItem[plantas.Count];

                int i = 0;
                foreach (PlantaModel item in plantas)
                {
                    plantaItems[i] = new plantaItem();
                    plantaItems[i].indiceLista = i;
                    plantaItems[i].nombre = item.Nombre.ToUpper();
                    Image image = byteArrayToImage(item.ImagenesConvertidas1[0]);
                    plantaItems[i].imagen = image;
                    plantaItems[i].PictureBoxClicked += PlantaItem_Click;
                    flowLayoutPanel1.Controls.Add(plantaItems[i]);
                    i++;
                }
            }
        }

        void PlantaItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");
            plantaItem plantaItem = (plantaItem)sender;
            txtdescripcion.Text = this.plantas[plantaItem.indiceLista].Descripcion.ToUpper();
            pbzImagenZoom.Image = plantaItem.imagen;
            jlbnombre.Text = plantaItem.nombre.ToUpper();
            var images = this.plantas[plantaItem.indiceLista].ImagenesConvertidas1.Select(x => byteArrayToImage(x));
            ListaImagenesPlanta = images.ToList();
            if (ListaImagenesPlanta.Count <= 1)
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
            }
            indicePlantaLista = plantaItem.indiceLista;


        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal form1 = new FormPrincipal();
            form1.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indiceImagenListaPlanta++;
            if (indiceImagenListaPlanta < ListaImagenesPlanta.Count)
                this.pbzImagenZoom.Image = ListaImagenesPlanta[indiceImagenListaPlanta];
            else
                indiceImagenListaPlanta--;

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

            indiceImagenListaPlanta--;
            if (indiceImagenListaPlanta >= 0)
                this.pbzImagenZoom.Image = ListaImagenesPlanta[indiceImagenListaPlanta];
            else
                indiceImagenListaPlanta++;
        }

        private void pictureBoxZoom_Click(object sender, EventArgs e)
        {

        }
    }
}
