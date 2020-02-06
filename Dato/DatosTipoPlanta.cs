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



        public int idTipoPlanta(string nombreTipo)
        {
            conectar();
            string sql = "select idTipo from tipo where tipo=@tipo";
            cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("tipo", nombreTipo);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                return int.Parse(myReader["idTipo"].ToString());

            }
            return -1;

        }


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

        public bool guardarTablaIntercepto(string sql, List<TipoPlanta> tipos, int fkPlanta)
        {
            try
            {
                if (conectar())
                {


                    cmd = new MySqlCommand(sql, connection);

                    foreach (TipoPlanta  item in tipos)
                    {
                        cmd.Parameters.AddWithValue("@IdTipo", item.Codigo);
                        cmd.Parameters.AddWithValue("@Idplanta", fkPlanta);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }




                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                desConectar();
            }
        }

       
    }
}
