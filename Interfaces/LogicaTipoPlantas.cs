using Dato;
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
        
        public ArrayList plantas;
        public DatosTipoPlanta DatosTipoPlanta;
        public LogicaTipoPlantas()
        {
            DatosTipoPlanta = new DatosTipoPlanta();
            plantas = new ArrayList();
        }
        //public ArrayList getAll()
        //{
        //    string sql = "select *from tipo";
        //    return plantas = DatosTipoPlanta.gellAll(sql);


        //}

    }
}
