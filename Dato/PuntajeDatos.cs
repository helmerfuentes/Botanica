using Datos;
using Entidades;
using Entidades.Enums;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Dato
{
    public class PuntajeDatos : Conexion
    {
        MySqlTransaction tr = null;

        public IEnumerable<PuntajeModel> ObtenerPuntajeByTipoJuego(TiposDeJuegoEnum tiposDeJuego)
        {
            Conectar();
            List<PuntajeModel> puntajes = new List<PuntajeModel>();
            string sql = @"SELECT 
                    ROW_NUMBER() OVER(ORDER BY puntaje ASC) AS numero,
                    nombre, 
                    puntaje 
                FROM 
                    jugador 
                WHERE 
                    tipoJuegoFk = @tipoJuegoFK 
                ORDER BY 
                    puntaje ASC;";

            cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("tipoJuegoFK", (int)tiposDeJuego);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                var puntaje = new PuntajeModel
                {
                    Jugador = myReader["nombre"].ToString(),
                    Puntaje = myReader["puntaje"].ToString(),
                    Posicion = int.Parse(myReader["numero"].ToString())
                };
                puntajes.Add(puntaje);
            }

            return puntajes;
        }


        public int GuardarPuntaje(string jugador, string puntaje, TiposDeJuegoEnum idTipoJuego)
        {
            Conectar();
            string sql = "insert into jugador(nombre,puntaje,tipoJuegoFk) values(@jugador,@puntaje,@tipoJuegoFk)";
            cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("jugador", jugador);
            cmd.Parameters.AddWithValue("puntaje", puntaje);
            cmd.Parameters.AddWithValue("tipoJuegoFk", (int)idTipoJuego);
            return cmd.ExecuteNonQuery();
        }
    }
}
