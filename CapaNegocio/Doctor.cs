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
    public class Doctor : Interfaces.IDoctor
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

        public string[] Actualizar(string idDoctor, string nombre, string apellidoPaterno, string apellidoMaterno, 
            string Especialidad, string direccion, string telefono, string idHospital)
        {
            DataRow fila = datos.TraerDataRow("spActualizarDoctor",
                                                idDoctor,
                                                nombre,
                                                apellidoPaterno,
                                                apellidoMaterno,
                                                Especialidad,
                                                direccion,
                                                telefono,
                                                idHospital);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public string[] Agregar(string idDoctor,
                                string nombre,
                                string apellidoPaterno,
                                string apellidoMaterno,
                                string Especialidad,
                                string direccion,
                                string telefono,
                                string idHospital)
        {
            DataRow fila = datos.TraerDataRow(  "spAddDoctor",
                                                idDoctor,
                                                nombre,
                                                apellidoPaterno,
                                                apellidoMaterno,
                                                Especialidad,
                                                direccion,
                                                telefono,
                                                idHospital);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public DataSet Buscar(string idDoctor)
        {
            //    DataRow dataRow = datos.TraerDataRow("spBuscarDoctor",idDoctor);
            //    //Console.WriteLine("es la data Row : "+dataRow);
            //    //DataRow fila = dataRow;
            //    byte codError = Convert.ToByte(dataRow["CodError"]);
            //    mensaje = dataRow["Mensaje"].ToString();
            //    string[] info = { mensaje, codError.ToString() };
            //    return info;
            //
            return datos.TraerDataSet("spBuscarDoctor", idDoctor);
        }

        public string[] Eliminar(string idDoctor)
        {
            DataRow fila = datos.TraerDataRow("spEliminarDoctor", idDoctor);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public DataSet listar()
        {
            return datos.TraerDataSet("spListarDoctor");
        }
    }





}
