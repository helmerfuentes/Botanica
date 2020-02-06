using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dato;
using Entidades;

namespace logica
{
  public  class LogicaPlanta
    {
        string sql;
        private DatosPlantas datosPlantas;
        private LogicaTipoPlantas LogicaTipo;
       public LogicaPlanta()
        {
            datosPlantas = new Dato.DatosPlantas();
            LogicaTipo = new LogicaTipoPlantas();
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

      
    }
}
