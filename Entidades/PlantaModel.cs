using System.Collections.Generic;

namespace Entidades
{
    public class PlantaModel
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private List<TipoPlanta> tipoPlanta;
        private List<string> imagenes;
        private List<byte[]> ImagenesConvertidas;

        public PlantaModel()
        {
            tipoPlanta = new List<TipoPlanta>();
            imagenes = new List<string>();

        }

        public PlantaModel(int codigo, string nombre, string descripcion)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;

        }

        public PlantaModel(int codigo, string nombre, string descripcion, List<TipoPlanta> tipoPlanta, List<string> imagenes)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.TipoPlanta = tipoPlanta;
            this.Imagenes = imagenes;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<TipoPlanta> TipoPlanta { get => tipoPlanta; set => tipoPlanta = value; }
        public List<string> Imagenes { get => imagenes; set => imagenes = value; }
        public List<byte[]> ImagenesConvertidas1 { get => ImagenesConvertidas; set => ImagenesConvertidas = value; }
    }
}
