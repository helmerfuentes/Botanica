using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class plantaItem : UserControl
    {
        public plantaItem()
        {
            InitializeComponent();
        }

        private string _nombre;
      
        private Image _imagen;

        private int _indiceLista;

        [Category("Custom Props")]
        public int indiceLista
        {
            get { return _indiceLista; }
            set { _indiceLista = value; }
        }


        [Category("Custom Props")]
        public Image imagen
        {
            get { return _imagen; }
            set { _imagen = value; pctImagen.Image = value; }
        }

        [Category("Custom Props")]
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; txtnombre.Text = value; }
        }

        private void pctImagen_Click(object sender, EventArgs e)
        {
        }
    }
}
