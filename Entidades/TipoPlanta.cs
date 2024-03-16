using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoPlanta
    {
        private int codigo;
        private  string descripcion,nombre;
        private List<PlantaModel> plantas;
            


        public TipoPlanta(int codigo, string descripcion, string nombre)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Nombre = nombre;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<PlantaModel> Plantas { get => plantas; set => plantas = value; }
    }
}
