using Datos;
using Entidades.DTO;

namespace Interfaces
{
    public class LogicaConexion
    {
        private readonly Conexion conexion;
        public LogicaConexion()
        {
            conexion = new Conexion();
        }

        public bool EstaConfiguradoParaAccederBD()
            => conexion.EstaConfiguradoParaAccederBD();

        public void SetValoresConexion(DatosConexionBDModels datosConexion)
            => conexion.SetValoresConexion(datosConexion);

        public void ConexionDisponible()
            => conexion.Conectar();


    }
}
