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
    public partial class VistaGeneral : Form
    {
        public VistaGeneral(string idTipoPlanta)
        {
            InitializeComponent();
           // cargarImagenes();
        }

        private void cargarImagenes()
        {
            OpenFileDialog examinar = new OpenFileDialog();
            examinar.Multiselect = true;
            examinar.Filter = "image files |*.jpg; *.png;";
            DialogResult r = examinar.ShowDialog();
            if (r == DialogResult.OK)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (string item in examinar.FileNames)
                {
                    PictureBox mpic = new PictureBox();
                    mpic.Image = Image.FromFile(item);
                    mpic.Width = 150;
                    mpic.Height = 150;
                    mpic.BorderStyle = BorderStyle.Fixed3D;
                    mpic.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel1.Controls.Add(mpic);

                  
                }
               


            }
        }

       
        private void PictureBox17_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
