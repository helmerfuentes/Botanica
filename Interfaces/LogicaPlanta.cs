using Dato;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool AgregarPlanta(PlantaModel planta)
        {
            var rutasImagenes = datosPlantas.SubirImagenesServidor(planta.Imagenes);
            var plantaResponse = datosPlantas.AgregarPlanta(planta);
            datosPlantas.AgregarImagenes(rutasImagenes, plantaResponse.Codigo);

            return LogicaTipo.guardarPlantaTipo(planta.TipoPlanta, planta.Codigo);

        }

        public int NumeroPlantas()
        {
            sql = "select count(*) as cantidad from planta";
            var numero = datosPlantas.NumeroPlantas(sql);
            return numero;

        }

        public IEnumerable<PlantaModel> GetPlantasParaJuego1Vs1()
        {
            var plantas = ObtenerTodasPlantas()
                .Take(8);

            foreach (var planta in plantas)
            {
                planta.ImagenesConvertidas1 = datosPlantas.ObtenerImagenId(planta.Codigo, limiteImagenes: 1);
            }

            return plantas;
        }


        public List<PlantaModel> ObtenerPlantasTipo(string idTipoPlanta)
        {
            try
            {
                List<PlantaModel> plantas;

                sql = "select idTipo, tp.tipo,tp.descripcion as descripcionTipo, pl.id as plantaId,pl.nombre, pl.descripcion from tipo tp " +
                        "inner join planta_tipo pt " +
                        "on tp.idTipo = pt.tipoFk " +
                        "inner join planta pl " +
                        "on pt.plantaFk = pl.id " +
                        "where idTipo = " + idTipoPlanta;

                plantas = datosPlantas.GetAllPlantaPorSQL(sql);

                if (plantas != null)
                {
                    foreach (PlantaModel item in plantas)
                    {

                        item.ImagenesConvertidas1 = datosPlantas.ObtenerImagenId(item.Codigo);

                    }
                }
                return plantas;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public PlantaModel getPlantaId(string idPlanta)
        {
            try
            {
                PlantaModel miPlanta;
                sql = "select * from planta where id=" + idPlanta;

                miPlanta = datosPlantas.PlantaId(sql);
                if (miPlanta != null)
                {
                    miPlanta.ImagenesConvertidas1 = datosPlantas.ObtenerImagenId(miPlanta.Codigo);

                    sql = "select tp.idTipo,tp.tipo,tp.descripcion from planta pl " +
                        "inner join planta_tipo pt " +
                        "on pl.id = pt.plantaFK " +
                        "inner join tipo tp " +
                        "on pt.tipoFK = tp.idTipo " +
                        "where pl.id =" + miPlanta.Codigo;
                    miPlanta.TipoPlanta = DatosTipoPlanta.ObtenerListadoTipoPlanta(sql);
                }
                //sql = "select ruta from imagen where plantaFk=";
                //miPlanta.ImagenesConvertidas1 = datosPlantas.ObtenerImagenId(sql, miPlanta.Codigo);
                return miPlanta;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private List<PlantaModel> ObtenerTodasPlantas()
        {
            sql = "select idTipo, tp.tipo,tp.descripcion as descripcionTipo, pl.id as plantaId,pl.nombre, pl.descripcion from tipo tp " +
                         "inner join planta_tipo pt " +
                         "on tp.idTipo = pt.tipoFk " +
                         "inner join planta pl " +
                         "on pt.plantaFk = pl.id ";
            var plantas = datosPlantas.GetAllPlantaPorSQL(sql);
            return plantas;
        }
    }
}
