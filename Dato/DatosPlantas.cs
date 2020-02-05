using Datos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class DatosPlantas : Conexion
    {
        private int codigoUltimoRegistro;

        public DatosPlantas()
        {
            keyUltimoRegistro();
        }





        //obtener el codigo de la ultima planta registrarla
        public void keyUltimoRegistro()
        {
            try
            {
                if (conectar())
                {

                    string sql = "select max(id) as ultimoId from planta";
                    cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        codigoUltimoRegistro = int.Parse(myReader["ultimoId"].ToString());

                    }

                   

                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
            finally
            {
                desConectar();
            }
        }
        public bool addImagenes(string sql,List<byte[]> imagenes)
        {
            try
            {
                if (conectar())
                {


                    cmd = new MySqlCommand(sql, connection);

                    foreach (byte[] item in imagenes)
                    {
                        cmd.Parameters.AddWithValue("@plantaFk", this.CodigoUltimoRegistro);
                        cmd.Parameters.AddWithValue("@imagen", item);

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

        public Planta agregarPlanta(string sql, Planta planta)

        {
            try
            {
                if (conectar())
                {

                    
                    cmd = new MySqlCommand(sql, connection);
                    
                    cmd.Parameters.AddWithValue("@nombre", planta.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", planta.Descripcion);
                    cmd.ExecuteNonQuery();
                    CodigoUltimoRegistro++;
                    planta.Codigo = codigoUltimoRegistro;
                   
                    return planta;


                }
                return null;
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
        public int CodigoUltimoRegistro { get => codigoUltimoRegistro; set => codigoUltimoRegistro = value; }
    

    }



        

    }
    
    


