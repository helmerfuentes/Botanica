using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class conexion
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=botanica;";
        MySqlConnection databaseConnection; 

        public bool abrir()
        {
            try
            {
             databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                Console.WriteLine("conecion correcta");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("error conectar "+e.Message);

                return false;
            }
           

        }

      public   void cerrar()
        {
            databaseConnection.Close();   
        }



    }
}
