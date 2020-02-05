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
       public LogicaPlanta()
        {
            datosPlantas = new Dato.DatosPlantas();
        }

        public bool addPlanta(Planta planta)
        {
            sql = "INSERT INTO PLANTA(nombre,descripcion) VALUES (@nombre,@descripcion)";

            if (datosPlantas.agregarPlanta(sql, planta) != null)
            {
                sql = "INSERT INTO IMAGEN(imagen,plantaFk) VALUES (@imagen,@plantaFk)";
              return  datosPlantas.addImagenes(sql, planta.Imagenes);
            }
            return false;
        }

    }
}
