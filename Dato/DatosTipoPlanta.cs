using Datos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class DatosTipoPlanta : Conexion
    {
        public MySqlCommand cmd;


        public ArrayList gellAll(string sql)
        {
            try
            {
                if (conectar())
                {
                    ArrayList lista = new ArrayList();

                    cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        TipoPlanta p = new TipoPlanta(int.Parse(myReader["idTipo"].ToString()), myReader["descripcion"].ToString(), myReader["tipo"].ToString());
                        lista.Add(p);

                    }

                    return lista;

                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                desConectar();
            }
        }

    }
}
