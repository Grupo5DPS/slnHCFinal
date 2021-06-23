using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaNegocio.Interfaces;

namespace CapaNegocio
{
    public class Hospital : Interfaces.IHospital
    {
        //llamar a la capa de datos 
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

        public string[] Actualizar(string idHo, string nombreHospital, string direccion)
        {
            DataRow fila = datos.TraerDataRow("spActualizarHospital", idHo, nombreHospital, direccion);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        public string[] Agregar(string idHo, string nombreHospital, string direccion)
        {
            DataRow fila = datos.TraerDataRow("spAddHospital", idHo, nombreHospital, direccion);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        //public string[] Buscar(string idHo)
        //{
        //    DataRow fila = datos.TraerDataRow("spBuscarHospital", idHo);
        //    //traer el codigo de error y el mensaje
        //    byte codError = Convert.ToByte(fila["CodError"]);

        //    mensaje = fila["Mensaje"].ToString();
        //    string[] aea = { mensaje, codError.ToString() };
        //    return aea;
        //}

        public string[] Eliminar(string idHo)
        {
            DataRow fila = datos.TraerDataRow("spEliminarHospital", idHo);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarHospital");
        }

        public DataSet Buscar(string idHo)
        {
            return datos.TraerDataSet("spBuscarHospital", idHo);
        }
    }
}
