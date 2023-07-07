using Datos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Dato
{
    public class DatosTipoPlanta : Conexion
    {


        MySqlTransaction tr = null;
        public int ObtenerIdTipoPlanta(string nombreTipo)
        {
            Conectar();
            string sql = "select idTipo from tipo where tipo=@tipo";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("tipo", nombreTipo);

            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                return int.Parse(myReader["idTipo"].ToString());

            }
            return -1;

        }


        public List<TipoPlanta> ObtenerListadoTipoPlanta(string sql)
        {
            try
            {
                Conectar();
                List<TipoPlanta> lista = new List<TipoPlanta>();

                cmd = new MySqlCommand(sql, connection);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    var idTipo = int.Parse(myReader["idTipo"].ToString());
                    var descripcion = myReader["descripcion"].ToString();
                    var tipo = myReader["tipo"].ToString();
                    TipoPlanta p = new TipoPlanta(idTipo, descripcion, tipo);
                    lista.Add(p);

                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                DesConectar();
            }
        }

        public bool GuardarTablaIntercepto(List<TipoPlanta> tipos, int fkPlanta)
        {
            string sql = "INSERT INTO PLANTA_TIPO(tipoFk,plantaFk) VALUES (@IdTipo,@IdPlanta)";
            try
            {

                Conectar();
                cmd = new MySqlCommand(sql, connection);
                tr = connection.BeginTransaction();
                cmd.Transaction = tr;

                foreach (TipoPlanta item in tipos)
                {
                    cmd.Parameters.AddWithValue("@IdTipo", item.Codigo);
                    cmd.Parameters.AddWithValue("@Idplanta", fkPlanta);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                tr.Commit();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                DesConectar();
            }
        }


    }
}
