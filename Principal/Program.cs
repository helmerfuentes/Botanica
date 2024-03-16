using Interfaces;
using Principal.FormularioJuego;
using System;
using System.Windows.Forms;

namespace Principal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogicaConexion logicaConexion = new LogicaConexion();
            try
            {
                JuegoPareja juegoPareja = new JuegoPareja();
                juegoPareja.Show();

                //logicaConexion.ConexionDisponible();
                //FormPrincipal main = new FormPrincipal();
                //main.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormConexionServerBD conexionServerBD = new FormConexionServerBD();
                conexionServerBD.Show();
            }

            //new FormularioJuego.JuegoPareja()
            Application.Run();
        }
    }
}
