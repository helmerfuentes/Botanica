﻿using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dato;
using Entidades;

namespace logica
{
    public class LogicaPlanta
    {
        string sql;
        private DatosPlantas datosPlantas;
        private DatosTipoPlanta DatosTipoPlanta;
        private LogicaTipoPlantas LogicaTipo;
        public LogicaPlanta()
        {
            datosPlantas = new Dato.DatosPlantas();
            LogicaTipo = new LogicaTipoPlantas();
            DatosTipoPlanta = new DatosTipoPlanta();
        }

        public bool addPlanta(Planta planta)
        {
            sql = "INSERT INTO PLANTA(nombre,descripcion) VALUES (@nombre,@descripcion)";
            if (datosPlantas.agregarPlanta(sql, planta) == null) return false;

            sql = "INSERT INTO IMAGEN(imagen,plantaFk) VALUES (@imagen,@plantaFk)";
            if (!datosPlantas.addImagenes(sql, planta.Imagenes)) return false;

            //obtengo los id que vienen en la lista que seleciono el usuario
            planta.TipoPlanta = LogicaTipo.obtenerIdTipo(planta.TipoPlanta);

            return LogicaTipo.guardarPlantaTipo(planta.TipoPlanta, planta.Codigo);



        }

        public int NumeroPlantas()
        {
            sql = "select count(*) as cantidad from planta";
            var numero= datosPlantas.NumeroPlantas(sql);
            return numero;

        }

        public List<Planta> getAllPlantaTipo(string idTipoPlanta)
        {
            try
            {
                List<Planta> plantas;

                sql = "select idTipo, tp.tipo,tp.descripcion as descripcionTipo, pl.id as plantaId,pl.nombre, pl.descripcion from tipo tp " +
                        "inner join planta_tipo pt " +
                        "on tp.idTipo = pt.tipoFk " +
                        "inner join planta pl " +
                        "on pt.plantaFk = pl.id " +
                        "where idTipo = " + idTipoPlanta;
                plantas = datosPlantas.getAllPlantaTipo(sql);

                if (plantas != null)
                {
                    sql = "select imagen from imagen where plantaFk=";
                    foreach (Planta item in plantas)
                    {

                        item.Imagenes = datosPlantas.obtenerImageneId(sql, item.Codigo);

                    }
                }
                return plantas;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Planta getPlantaId(string idPlanta)
        {
            try
            {
                Planta miPlanta;
               sql = "select * from planta where id=" + idPlanta;

                miPlanta= datosPlantas.PlantaId(sql);
                if (miPlanta != null) {
                    sql = "select imagen from imagen where plantaFk=";
                    //miPlanta.Imagenes = datosPlantas.obtenerImageneId(sql, miPlanta.Codigo);

                    sql = "select tp.idTipo,tp.tipo,tp.descripcion from planta pl " +
                        "inner join planta_tipo pt " +
                        "on pl.id = pt.plantaFK " +
                        "inner join tipo tp " +
                        "on pt.tipoFK = tp.idTipo " +
                        "where pl.id =" + miPlanta.Codigo;
                    miPlanta.TipoPlanta = DatosTipoPlanta.gellAll(sql);
                    return miPlanta;
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }




        }





    }
}
