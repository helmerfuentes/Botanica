using Datos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Dato
{
    public class DatosPlantas : Conexion
    {
        MySqlTransaction tr = null;
        private string SERVIDOR_FORMATO = "ftp://{0}/";

        public DatosPlantas()
        {
        }

        public int NumeroPlantas(string sql)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand(sql, connection);

                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    return int.Parse(myReader["cantidad"].ToString());

                }
                return -1;
            }
            catch (Exception)
            {
                return -1;

                throw;
            }
        }

        public bool AgregarImagenes(IEnumerable<string> paths, int plantaFk)
        {
            var sql = "INSERT INTO IMAGEN(ruta,plantaFk) VALUES (@path,@plantaFk)";
            try
            {
                Conectar();
                cmd = new MySqlCommand(sql, connection);
                tr = connection.BeginTransaction();
                cmd.Transaction = tr;

                foreach (string path in paths)
                {
                    cmd.Parameters.AddWithValue("@plantaFk", plantaFk);
                    cmd.Parameters.AddWithValue("@path", path);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
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
                DesConectar();
            }
        }

        private byte[] ObtenerImagenServidor(string nombreImagen)
        {
            string ruta = $"{string.Format(SERVIDOR_FORMATO, servidor)}{nombreImagen}";
            using (WebClient ftpClient = new WebClient())
            {
                ftpClient.Credentials = new NetworkCredential(usuario, password);
                byte[] imageBytes = ftpClient.DownloadData(ruta);

                return imageBytes;
            }
        }

        private string GenerarNombreAletorio(string rutaOrigen)
        {
            var extension = Path.GetExtension(rutaOrigen);
            int longitud = 15;
            Guid miGuid = Guid.NewGuid();
            string nombreNuevo = miGuid.ToString().Replace("-", string.Empty).Substring(0, longitud);
            return $"{nombreNuevo}{extension}";
        }

        private string SubirImagenServidor(string url)
        {
            try
            {
                var nombreNuevoArchivo = GenerarNombreAletorio(url);
                var urlServidor = $"{string.Format(SERVIDOR_FORMATO, servidor)}{nombreNuevoArchivo}";
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(urlServidor);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(usuario, password);
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
                return nombreNuevoArchivo;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error al subir imagen servidor ", ex);
            }
        }

        public PlantaModel PlantaId(string sql)
        {
            try
            {
                PlantaModel p = new PlantaModel();
                Conectar();
                cmd = new MySqlCommand(sql, connection);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    p.Codigo = int.Parse(myReader["id"].ToString());
                    p.Nombre = myReader["nombre"].ToString();
                    p.Descripcion = myReader["descripcion"].ToString();
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
                DesConectar();
            }
        }

        public List<byte[]> ObtenerImagenId(int codigo, int limiteImagenes = int.MaxValue)
        {
            try
            {
                Conectar();
                List<byte[]> imagenes = new List<byte[]>();
                //concatenar el codigo de la planta para el where de la consulta
                var sql = "select ruta from imagen where plantaFk = @codigo LIMIT @limite";
                cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("codigo", codigo);
                cmd.Parameters.AddWithValue("limite", limiteImagenes);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string NombreImagen = (string)(myReader["ruta"]);
                    var imagen = ObtenerImagenServidor(NombreImagen);
                    imagenes.Add(imagen);
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
                DesConectar();
            }
        }

        public List<PlantaModel> GetAllPlantaPorSQL(string sql)
        {
            List<PlantaModel> plantas = new List<PlantaModel>();
            try
            {
                Conectar();
                cmd = new MySqlCommand(sql, connection);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    var tipoPlanta = new TipoPlanta(int.Parse(myReader["idTipo"].ToString()), myReader["descripcionTipo"].ToString(), myReader["tipo"].ToString());
                    PlantaModel planta = new PlantaModel
                    {
                        Codigo = int.Parse(myReader["plantaId"].ToString()),
                        Nombre = myReader["nombre"].ToString(),
                        Descripcion = myReader["descripcion"].ToString(),
                        TipoPlanta = new List<TipoPlanta> { tipoPlanta }

                    };
                    plantas.Add(planta);
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
                DesConectar();
            }
        }

        public PlantaModel AgregarPlanta(PlantaModel planta)
        {
            var sql = "INSERT INTO PLANTA(nombre,descripcion) VALUES (@nombre,@descripcion);SELECT LAST_INSERT_ID();";
            try
            {
                Conectar();
                cmd = new MySqlCommand(sql, connection)
                {
                    Transaction = tr
                };

                cmd.Parameters.AddWithValue("@nombre", planta.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", planta.Descripcion);
                var identificador = cmd.ExecuteScalar();
                planta.Codigo = Convert.ToInt32(identificador);
                return planta;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar datos de planta", e);
            }
            finally
            {
                DesConectar();
            }

        }

        public IEnumerable<string> SubirImagenesServidor(IEnumerable<string> imagenes)
        {
            List<string> paths = new List<string>();
            foreach (var item in imagenes)
            {
                var ruta = SubirImagenServidor(item);
                paths.Add(ruta);
            }
            return paths;

        }
    }





}




