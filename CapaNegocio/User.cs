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
    public class User : Interfaces.IUser
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
        public DataSet Listar()
        {
            //llamar procedimineto almacenado listar paciente
            return datos.TraerDataSet("spListarUsuario");
        }

        public string[] Agregar(string idUsuario, string usuario, string contrasenia)
        {
            DataRow fila    = datos.TraerDataRow("spAddUsuario", idUsuario, usuario, contrasenia);
            byte codError   = Convert.ToByte(fila["CodError"]);
            mensaje         = fila["Mensaje"].ToString();
            string[] info   = { mensaje, codError.ToString() };
            return info;
        }

        public string[] Actualizar(string idUsuario, string usuario, string contrasenia)
        {
            DataRow fila = datos.TraerDataRow("spActualizarUsuario", idUsuario, usuario, contrasenia);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public string[] Eliminar(string idUsuario)
        {
            DataRow fila = datos.TraerDataRow("spEliminarUsuario", idUsuario);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        //public string[] Buscar(string idUsuario)
        //{
        //    DataRow fila = datos.TraerDataRow("spBuscarUsuario", idUsuario);
        //    byte codError = Convert.ToByte(fila["CodError"]);
        //    mensaje = fila["Mensaje"].ToString();
        //    string[] info = { mensaje, codError.ToString() };
        //    return info;
        //}

        public DataSet Buscar(string idUsuario)
        {
            return datos.TraerDataSet("spBuscarUsuario", idUsuario);
        }
    }
}
