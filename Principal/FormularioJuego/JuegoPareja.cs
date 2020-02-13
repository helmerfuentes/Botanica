using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.FormularioJuego
{
    public partial class JuegoPareja : Form
    {
        int TamanioColimnasFilas = 4;
        int movimientos = 0;
        int cantidadesCartasVolteadas = 0;
        List<string> cartasEnumeradas;
        List<string> CartasRevueltaa;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;
        public JuegoPareja()
        {
            InitializeComponent();
            IniciarJuego();
        }

        public void IniciarJuego()
        {
            timer1.Enabled = true;
            timer1.Stop();
            jlbRecord.Text = "0";
            cantidadesCartasVolteadas = 0;
            movimientos = 0;
            panelJuego.Controls.Clear();
            cartasEnumeradas = new List<string>();
            CartasRevueltaa = new List<string>();
            CartasSeleccionadas = new ArrayList();

            for (int i = 0; i < 8; i++)
            {
                cartasEnumeradas.Add(i.ToString());
                cartasEnumeradas.Add(i.ToString());
            }
            var numeroAleatorio = new Random();
            var resultado = cartasEnumeradas.OrderBy(item => numeroAleatorio.Next());
            foreach (string valorCarta in resultado)
            {
                CartasRevueltaa.Add(valorCarta);
            }

            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioColimnasFilas;
            tablaPanel.ColumnCount = TamanioColimnasFilas;
            for (int i = 0; i < TamanioColimnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamanioColimnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));

            }
            int contadorFichas = 1;
            for (int i = 0; i < TamanioColimnasFilas; i++)
            {
                for (int j = 0; j < TamanioColimnasFilas; j++)
                {
                    var CartaJuego = new PictureBox();
                    CartaJuego.Name = string.Format("{0}", contadorFichas);
                    CartaJuego.Dock = DockStyle.Fill;
                    CartaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartaJuego.Image = Properties.Resources.RIK;
                    CartaJuego.Cursor = Cursors.Hand;
                    tablaPanel.Controls.Add(CartaJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            panelJuego.Controls.Add(tablaPanel);
          
        }

    }
}
