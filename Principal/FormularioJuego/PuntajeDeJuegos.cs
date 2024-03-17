using Dato;
using Entidades.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace Principal.FormularioJuego
{
    public partial class PuntajeDeJuegos : Form
    {
        private PuntajeDatos puntajeDatos;
        private TiposDeJuegoEnum tiposDeJuego;

        public PuntajeDeJuegos(TiposDeJuegoEnum tiposDeJuego)
        {
            InitializeComponent();
            this.tiposDeJuego = tiposDeJuego;

            CargarPuntajes();
        }

        public void CargarPuntajes()
        {
            puntajeDatos = new PuntajeDatos();
            switch (tiposDeJuego)
            {
                case TiposDeJuegoEnum.Botanico:
                    tablaPuntaje.DataSource = puntajeDatos.ObtenerPuntajeByTipoJuego(tiposDeJuego);
                    break;
                case TiposDeJuegoEnum.Memoria:
                    tablaPuntaje.DataSource = puntajeDatos.ObtenerPuntajeByTipoJuego(tiposDeJuego, "tiempo");
                    break;
            }
            foreach (DataGridViewColumn column in tablaPuntaje.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void tablaPuntaje_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            Color color1 = Color.LightBlue;
            Color color2 = Color.LightGreen;

            // Alterna entre los dos colores basándose en el índice de la fila
            if (e.RowIndex % 2 == 0)
            {
                tablaPuntaje.Rows[e.RowIndex].DefaultCellStyle.BackColor = color1;
            }
            else
            {
                tablaPuntaje.Rows[e.RowIndex].DefaultCellStyle.BackColor = color2;
            }
        }

        private void pictureBox17_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
