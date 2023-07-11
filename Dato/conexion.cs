
using Entidades.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Xml;

namespace Datos
{
    public class Conexion
    {
        public MySqlConnection connection;
        public string servidor = "192.168.0.108";
        public string password = "root";
        public string usuario = "root";
        private string puerto = "3306";
        private string database = "botanica";

        public MySqlCommand cmd;

        //Cadena de conexion
        private string _CONNECTION_STRING = ("server={0};port={1};user id={2}; password={3}; " +
            "database={4}; pooling=false;SslMode=none; AllowPublicKeyRetrieval=true;persistsecurityinfo=True;" +
            "Allow Zero Datetime=False;Convert Zero Datetime=True");

        public Conexion()
        {
            ObtenerValoresAppConfig();

        }

        public void SetValoresConexion(DatosConexionBDModels datosConexionBD)
        {
            servidor = datosConexionBD.Servidor;
            puerto = datosConexionBD.Puerto;
            usuario = datosConexionBD.Usuario;
            password = datosConexionBD.Password;
            Conectar();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xmlDocument.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "servidor")
                        {
                            node.Attributes[1].Value = datosConexionBD.Servidor;
                        }
                        else if (node.Attributes[0].Value == "usuario")
                        {
                            node.Attributes[1].Value = datosConexionBD.Usuario;
                        }
                        else if (node.Attributes[0].Value == "puerto")
                        {
                            node.Attributes[1].Value = datosConexionBD.Puerto;
                        }
                        else if (node.Attributes[0].Value == "password")
                        {
                            node.Attributes[1].Value = datosConexionBD.Password;
                        }
                        else if (node.Attributes[0].Value == "conexionExitosa")
                        {
                            node.Attributes[1].Value = "true";
                        }

                    }
                }
            }
            xmlDocument.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void ObtenerValoresAppConfig()
        {
            servidor = ConfigurationManager.AppSettings["servidor"];
            puerto = ConfigurationManager.AppSettings["puerto"];
            usuario = ConfigurationManager.AppSettings["usuario"];
            password = ConfigurationManager.AppSettings["password"];
        }

        public void Conectar()
        {
            try
            {
                var connectionFormat = string.Format(_CONNECTION_STRING, servidor, puerto, usuario, password, database);
                connection = new MySqlConnection(connectionFormat);
                connection.Open();
            }
            catch (Exception ex)
            {
                SetAppConfigKeyConexionExitosa(false);
                throw new Exception("Error al conectar al servidor BD", ex); ;
            }
        }

        private void SetAppConfigKeyConexionExitosa(bool exitoso)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xmlDocument.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {

                        if (node.Attributes[0].Value == "conexionExitosa")
                        {
                            node.Attributes[1].Value = exitoso.ToString();
                        }

                    }
                }
            }
            xmlDocument.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void DesConectar()
        {
            try
            {
                var connectionFormat = string.Format(_CONNECTION_STRING, servidor, puerto, usuario, password, database);
                connection = new MySqlConnection(connectionFormat);
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al desconectar BD", ex);
            }
        }

    }
}