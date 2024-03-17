using Datos;
using Entidades;
using Entidades.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Dato
{
    public class PuntajeDatos : Conexion
    {
        MySqlTransaction tr = null;

        public IEnumerable<PuntajeModel> ObtenerPuntajeByTipoJuego(TiposDeJuegoEnum tiposDeJuego, string order = "puntaje")
        {
            Conectar();
            List<PuntajeModel> puntajes = new List<PuntajeModel>();
            string sql = @"SELECT 
                    ROW_NUMBER() OVER(ORDER BY puntaje ASC) AS numero,
                    nombre, 
                    puntaje,
                    tiempo
                FROM 
                    jugador 
                WHERE 
                    tipoJuegoFk = @tipoJuegoFK  
                ORDER BY 
                    @order ASC;";

            cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("tipoJuegoFK", (int)tiposDeJuego);
            cmd.Parameters.AddWithValue("order", order);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                var puntaje = new PuntajeModel
                {
                    Jugador = myReader["nombre"].ToString(),
                    Puntaje =  tiposDeJuego== TiposDeJuegoEnum.Botanico
                    ?myReader["puntaje"].ToString()
                    : myReader["tiempo"].ToString(),
                    Posicion = int.Parse(myReader["numero"].ToString())
                };
                puntajes.Add(puntaje);
            }

            return puntajes;
        }


        public int GuardarPuntaje(string jugador, string puntaje, TiposDeJuegoEnum idTipoJuego, string tiempo)
        {
            Conectar();
            string sql = "insert into jugador(nombre,puntaje,tipoJuegoFk, tiempo) values(@jugador, @puntaje ,@tipoJuegoFk, @tiempo)";
            cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("jugador", jugador);
            cmd.Parameters.AddWithValue("puntaje", puntaje);
            cmd.Parameters.AddWithValue("tipoJuegoFk", (int)idTipoJuego);
            cmd.Parameters.AddWithValue("tiempo", tiempo);
            return cmd.ExecuteNonQuery();
        }
    }
}