using Datos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

        public int NumeroPlantas(string sql)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand(sql, connection);



                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        return int.Parse(myReader["cantidad"].ToString());

                    }
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;

                throw;
            }
        }

        public bool addImagenes(string sql, List<string> imagenes)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand(sql, connection);
                    tr = connection.BeginTransaction();
                    cmd.Transaction = tr;

                    foreach (string item in imagenes)
                    {
                        var NuevoNombre = obtenerNombreAletorio();
                        NuevoNombre += Path.GetExtension(item);
                        if (SubirImagenServidor(item,NuevoNombre) == 0) return false;
                        cmd.Parameters.AddWithValue("@plantaFk", this.CodigoUltimoRegistro);
                        cmd.Parameters.AddWithValue("@imagen", NuevoNombre);
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

        private int leerImagenServidor(string ruta)
        {
            return 1;
        }
        private void otro()
        {
           // string img = "http://192.168.1.4/botanic/img/0.jpg";
            //pictureBox1.Image = System.Drawing.Image.FromStream(getUrl(img));
        }
        private Stream getUrl(string URL)
        {
            HttpWebRequest request = ((HttpWebRequest)WebRequest.Create(URL));
            HttpWebResponse response = ((HttpWebResponse)request.GetResponse());
            try
            {
                return response.GetResponseStream();
            }
            catch
            {
                return response.GetResponseStream();
            }
        }

        string obtenerNombreAletorio()
        {
            int longitud = 7;
            Guid miGuid = Guid.NewGuid();
            string nombreNuevo = miGuid.ToString().Replace("-", string.Empty).Substring(0, longitud);
            return nombreNuevo;
        }

        private int SubirImagenServidor(string url,string nombreFile)
        {

            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://127.0.0.1/" + nombreFile);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("usuario", "helmer");
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = true;
            FileStream stream = File.OpenRead(url);
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            stream.Close();
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(buffer, 0, buffer.Length);
            reqStream.Flush();
            reqStream.Close();
            return 1;


        }

        public Planta PlantaId(string sql)
        {
            try
            {
                Planta p = new Planta();
                if (conectar())
                {


                    cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {

                        p.Codigo = int.Parse(myReader["id"].ToString());
                        p.Nombre = myReader["nombre"].ToString();
                        p.Descripcion = myReader["descripcion"].ToString();
                        //p.TipoPlanta.Add(new TipoPlanta(int.Parse(myReader["idTipo"].ToString()), myReader["descripcionTipo"].ToString(), myReader["tipo"].ToString()));

                    }



                }
                return p;
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

        

        public List<string> obtenerImageneId(string sql, int codigo)
        {
            List<string> imagenes = null;

            try
            {
                if (conectar())
                {
                    string ruta = "http://192.168.1.4/botanic/img/";
                    imagenes = new List<string>();
                    //concatenar el codigo de la planta para el where de la consulta
                    sql += codigo;
                    cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {

                        string NombreImagen = (string)(myReader["imagen"]);
                        ruta += NombreImagen;

                        imagenes.Add(getUrl(ruta).ToString());

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
            List<Planta> plantas = null;
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

                    tr = connection.BeginTransaction();
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




