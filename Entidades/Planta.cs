using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planta
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private List<TipoPlanta> tipoPlanta;
        private List<byte[]> imagenes;

        public Planta()
        {

        }

        public Planta(int codigo, string nombre, string descripcion)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;

        }

        public Planta(int codigo, string nombre, string descripcion, List<TipoPlanta> tipoPlanta, List<byte[]> imagenes)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipoPlanta = tipoPlanta;
            this.imagenes = imagenes;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

    }
}
