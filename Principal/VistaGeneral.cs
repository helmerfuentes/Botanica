using Entidades;
using logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class VistaGeneral : Form
    {
        List<Planta> plantas;
        LogicaPlanta LogicaPlanta;
        List<byte[]> ListaImagenesPlanta;
        int indiceImagenListaPlanta=0;
        int indicePlantaLista;
        public VistaGeneral(string idTipoPlanta)
        {
            InitializeComponent();
            LogicaPlanta = new LogicaPlanta();
           cargarImagenes(idTipoPlanta);
        }

        private void cargarImagenes(string tipo)
        {
            plantas = LogicaPlanta.getAllPlantaTipo(tipo);
            if (plantas != null)
            {
                plantaItem[] plantaItems = new plantaItem[plantas.Count];

                int i = 0;
            foreach (Planta item in plantas)
            {
                   
                    plantaItems[i] = new plantaItem();
                    plantaItems[i].indiceLista = i;
                    plantaItems[i].nombre = item.Nombre.ToUpper();
                    Image image = byteArrayToImage(item.Imagenes[0]);
                    plantaItems[i].imagen = image;
                    

                    plantaItems[i].Click+= new System.EventHandler(this.itemClick);
                    flowLayoutPanel1.Controls.Add(plantaItems[i]);
                        i++;
            }

            }
           


            //OpenFileDialog examinar = new OpenFileDialog();
            //examinar.Multiselect = true;
            //examinar.Filter = "image files |*.jpg; *.png;";
            //DialogResult r = examinar.ShowDialog();
            //if (r == DialogResult.OK)
            //{
            //    flowLayoutPanel1.Controls.Clear();
            //    foreach (string item in examinar.FileNames)
            //    {
            //        PictureBox mpic = new PictureBox();
            //        mpic.Image = Image.FromFile(item);
            //        mpic.Width = 150;
            //        mpic.Height = 150;
            //        mpic.BorderStyle = BorderStyle.Fixed3D;
            //        mpic.SizeMode = PictureBoxSizeMode.StretchImage;
            //        flowLayoutPanel1.Controls.Add(mpic);

                  
            //    }
               


            //}
        }


        void itemClick(object sender, EventArgs e)
        {
            plantaItem plantaItem = (plantaItem)sender;
            txtdescripcion.Text = this.plantas[plantaItem.indiceLista].Descripcion.ToUpper();
            pictureBoxZoom.Image = plantaItem.imagen;
            jlbnombre.Text = plantaItem.nombre.ToUpper();
            ListaImagenesPlanta= this.plantas[plantaItem.indiceLista].Imagenes;
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
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indiceImagenListaPlanta++;
            if (indiceImagenListaPlanta < ListaImagenesPlanta.Count)
                this.pictureBoxZoom.Image = byteArrayToImage(ListaImagenesPlanta[indiceImagenListaPlanta]);
            else
                indiceImagenListaPlanta--;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

            indiceImagenListaPlanta--;
            if (indiceImagenListaPlanta>=0)
                this.pictureBoxZoom.Image = byteArrayToImage(ListaImagenesPlanta[indiceImagenListaPlanta]);
            else
                indiceImagenListaPlanta++;

        }
    }
}
