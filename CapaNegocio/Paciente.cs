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
    public class Paciente : Interfaces.IPaciente
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

        public string[] Actualizar(string idPaciente, string nombre, string apellidoPaterno, string apellidoMaterno, 
            string dni, string edad, string sexo, string fechaNacimiento, string estadoCivil, string ocupacion, 
            string direccion, string telefono, string fechaIngreso)
        {
            DataRow fila = datos.TraerDataRow("spActualizarPaciente", idPaciente, nombre, apellidoPaterno, apellidoMaterno,
            dni, edad, sexo, fechaNacimiento, estadoCivil, ocupacion, direccion, telefono, fechaIngreso);

            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }


        //public string[] Agregar(PacienteE paciente 
        public string[] Agregar(string idPaciente, string nombre, string apellidoPaterno, string apellidoMaterno,
            string dni, string edad, string sexo, string fechaNacimiento, string estadoCivil, string ocupacion,
            string direccion, string telefono, string fechaIngreso)
        {

            DataRow fila = datos.TraerDataRow("spAddPaciente", idPaciente, nombre, apellidoPaterno, apellidoMaterno,
            dni, edad, sexo, fechaNacimiento, estadoCivil, ocupacion, direccion, telefono, fechaIngreso);

            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }


        //public string[] Buscar(string idPaciente)
        //{
        //    DataRow fila = datos.TraerDataRow("spBuscarPaciente", idPaciente);

        //    //traer el codigo de error y el mensaje
        //    byte codError = Convert.ToByte(fila["CodError"]);

        //    mensaje = fila["Mensaje"].ToString();
        //    string[] aea = { mensaje, codError.ToString() };
        //    return aea;
        //}

        public string[] Eliminar(string idPaciente)
        {
            DataRow fila = datos.TraerDataRow("spEliminarPaciente", idPaciente);

            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarPaciente");
        }

        public DataSet Buscar(string idPaciente)
        {
            return datos.TraerDataSet("spBuscarPaciente", idPaciente);
        }
    }
}
