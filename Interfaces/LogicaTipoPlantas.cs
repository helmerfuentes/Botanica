using Dato;
using Entidades;
using System.Collections.Generic;

namespace logica
{
    public class LogicaTipoPlantas
    {

        private List<TipoPlanta> TipoPlantas;
        private DatosTipoPlanta DatosTipoPlanta;
        public LogicaTipoPlantas()
        {
            DatosTipoPlanta = new DatosTipoPlanta();
            TipoPlantas = new List<TipoPlanta>();
        }

        public List<TipoPlanta> getAll()
        {
            string sql = "select *from tipo";
            return TipoPlantas = DatosTipoPlanta.ObtenerListadoTipoPlanta(sql);
        }

        public List<TipoPlanta> getNoTipo(int codigoPlanta)
        {
            string sql = string.Format("select idTipo,tipo,descripcion from tipo where " +
                     "idTipo  not in ( " +
                    "select tipoFK from planta_tipo pt " +
                    "inner join planta pl " +
                    "on pl.id = pt.plantaFK " +
                    "where pl.id = {0})", codigoPlanta);
            return DatosTipoPlanta.ObtenerListadoTipoPlanta(sql);
        }

        public List<TipoPlanta> obtenerIdTipo(List<TipoPlanta> tipos)
        {
            getAll();
            foreach (TipoPlanta item in tipos)
            {
                foreach (TipoPlanta items in TipoPlantas)
                {
                    if (item.Nombre.Equals(items.Nombre))
                        item.Codigo = items.Codigo;
                }
            }
            return tipos;

        }
        // guado en la tabla intercepto Planta_Tipo
        public bool guardarPlantaTipo(List<TipoPlanta> tipos, int FkPlanta)
            => DatosTipoPlanta.GuardarTablaIntercepto(tipos, FkPlanta);

    }
}
