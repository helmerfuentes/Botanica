using Datos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class DatosPlantas : Conexion
    {
        private int codigoUltimoRegistro;
        MySqlTransaction tr = null;

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
                codigoUltimoRegistro = 0;
               
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
                ExpandirEspacio();
                if (conectar())
                {
                    

                    cmd = new MySqlCommand(sql,connection);
                    tr=connection.BeginTransaction();

                    cmd.Transaction = tr;

                    foreach (byte[] item in imagenes)
                    {
                        cmd.Parameters.AddWithValue("@plantaFk", this.CodigoUltimoRegistro);
                        cmd.Parameters.AddWithValue("@imagen", item);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                 
                  


                }
                tr.Commit();
                return true;
            }
            catch (Exception e)
            {
                tr.Rollback();
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                desConectar();
            }
        }

        private void ExpandirEspacio()
        {
            try
            {       
                if (conectar())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SET GLOBAL max_allowed_packet=32*1024*1024;";
                    cmd.ExecuteNonQuery();
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

        public List<byte[]> obtenerImageneId(string sql, int codigo)
        {
            List<byte[]> imagenes= null;
            
            try
            {
                if (conectar())
                {
                    imagenes = new List<byte[]>();
                    //concatenar el codigo de la planta para el where de la consulta
                    sql+= codigo;
                    cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        byte[] imagen = (byte[])(myReader["imagen"]);
                        imagenes.Add(imagen);
                      
                    }



                }
                return imagenes;
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

        public List<Planta> getAllPlantaTipo(string sql)
        {
            List<Planta> plantas=null;
            Planta p;
            try
            {
                if (conectar())
                {
                    plantas = new List<Planta>();

                    cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        p = new Planta();
                        p.Codigo = int.Parse(myReader["plantaId"].ToString());
                        p.Nombre = myReader["nombre"].ToString();
                        p.Descripcion = myReader["descripcion"].ToString();
                        p.TipoPlanta.Add(new TipoPlanta(int.Parse(myReader["idTipo"].ToString()), myReader["descripcionTipo"].ToString(), myReader["tipo"].ToString()));
                        plantas.Add(p);
                    }



                }
                return plantas;
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

        public Planta agregarPlanta(string sql, Planta planta)

        {
            try
            {
               
                if (conectar())
                {

                    tr=connection.BeginTransaction();
                    cmd = new MySqlCommand(sql, connection);
                    cmd.Transaction = tr;
                    cmd.Parameters.AddWithValue("@nombre", planta.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", planta.Descripcion);
                    cmd.ExecuteNonQuery();
                    CodigoUltimoRegistro++;
                    planta.Codigo = codigoUltimoRegistro;

                    tr.Commit();
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
    
    


