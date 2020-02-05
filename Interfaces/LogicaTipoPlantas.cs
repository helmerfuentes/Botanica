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
        
        private ArrayList TipoPlantas;
        private DatosTipoPlanta DatosTipoPlanta;
        public LogicaTipoPlantas()
        {
            DatosTipoPlanta = new DatosTipoPlanta();
            TipoPlantas = new ArrayList();
        }
        public ArrayList getAll()
        {
            string sql = "select *from tipo";
            return TipoPlantas = DatosTipoPlanta.gellAll(sql);


        }

    }
}
