using Entidades.DTO;
using Interfaces;
using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class FormConexionServerBD : Form
    {
        private readonly LogicaConexion logicaConexion;
        public FormConexionServerBD()
        {
            logicaConexion = new LogicaConexion();
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, System.EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var password = txtPassword.Text;
            var servidor = txtServidor.Text;
            var puerto = txtPuerto.Text;

            try
            {
                if (usuario == string.Empty || password == string.Empty || servidor == string.Empty || puerto == string.Empty)
                {
                    MessageBox.Show("Datos faltantes");
                }
                else
                {
                    var datosConexion = new DatosConexionBDModels
                    {
                        Password = password,
                        Servidor = servidor,
                        Puerto = puerto,
                        Usuario = usuario
                    };

                    logicaConexion.SetValoresConexion(datosConexion);
                    this.Close();
                    FormPrincipal main = new FormPrincipal();
                    main.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
