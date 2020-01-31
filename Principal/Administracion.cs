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
    public partial class e : Form
    {
        public e()
        {
            InitializeComponent();
        }

        private void chbvuelnerarias_OnChange(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog examinar = new OpenFileDialog();
            examinar.Filter = "image files |*.jpg; *.png;";
            DialogResult r = examinar.ShowDialog();
            if (r == DialogResult.Abort || r==DialogResult.Cancel)
            {
                return;
            }
            else
            {
                    //pcImagen.Image.=Image.FromFile.(examinar)
            }
        }
    }
}
