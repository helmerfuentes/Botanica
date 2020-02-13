using Dato;
using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return TipoPlantas = DatosTipoPlanta.gellAll(sql);


        }
        
        public List<TipoPlanta> getNoTipo(int codigoPlanta)
        {
            string sql = string.Format("select idTipo,tipo,descripcion from tipo where " +
                     "idTipo  not in ( " +
                    "select tipoFK from planta_tipo pt " +
                    "inner join planta pl " +
                    "on pl.id = pt.plantaFK " +
                    "where pl.id = {0})",codigoPlanta);
            return DatosTipoPlanta.gellAll(sql);
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
       public bool guardarPlantaTipo(List<TipoPlanta> tipos,int FkPlanta)
        {
            string sql = "INSERT INTO PLANTA_TIPO(tipoFk,plantaFk) VALUES (@IdTipo,@IdPlanta)";
            if(!DatosTipoPlanta.guardarTablaIntercepto(sql,tipos,FkPlanta)) return false;
            return true;

        }

    }
}
