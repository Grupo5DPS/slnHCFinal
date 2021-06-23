using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDatos;
using CapaEntidad;
using CapaNegocio.Interfaces;
namespace CapaNegocio
{
    public class Diagnostico : Interfaces.IDiagnostico
    {
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del PAT
        string mensaje;
        public string Mensaje
        {
            get
            {
                return mensaje;
            }
        }

        public string[] Actualizar(string codDiagnostico, string descripcion)
        {
            DataRow fila = datos.TraerDataRow("spActualizarDiagnosticos", codDiagnostico, descripcion);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public string[] Agregar(string codDiagnostico, string descripcion)
        {
            DataRow fila = datos.TraerDataRow("spAddDiagnostico", codDiagnostico, descripcion);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        //public string[] Buscar(string codDiagnostico)
        //{
        //    DataRow fila = datos.TraerDataRow("spBuscarDiagnostico", codDiagnostico);
        //    byte codError = Convert.ToByte(fila["CodError"]);
        //    mensaje = fila["Mensaje"].ToString();
        //    string[] info = { mensaje, codError.ToString() };
        //    return info;
        //}

        public string[] Eliminar(string codDiagnostico)
        {
            DataRow fila = datos.TraerDataRow("spEliminarDiagnostico", codDiagnostico);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarDiagnostico");
        }

        public DataSet Buscar(string codDiagnostico)
        {
            return datos.TraerDataSet("spBuscarDiagnostico", codDiagnostico);
        }
    }
}
