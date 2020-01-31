
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class Conexion
    {
        public MySqlConnection connection;
        private const string servidor = "127.0.0.1";
        private const string puerto = "3306";
        private const string usuario = "root";
        private const string password = "";
        private const string database = "botanica";


        //Cadena de conexion
        public string connectionString =
            String.Format("server={0};port={1};user id={2}; password={3}; " +
            "database={4}; pooling=false;SslMode=none;" +
            "Allow Zero Datetime=False;Convert Zero Datetime=True",
            servidor, puerto, usuario, password, database);

        public bool conectar()
        {
            try
            {

                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("conexion exitosa");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Error Conectar");
                return false;

            }
        }

        public bool desConectar()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
       
    }
}