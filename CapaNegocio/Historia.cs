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
    public class Historia : Interfaces.IHistoria
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

        public string[] Actualizar(string idHistoria, string peso, string talla, string motivo, string sintomas, 
            string adicciones, string motivoConsulta, string idPaciente, string idDoctor, 
            string idUsuario, string idHospital, string idAntecedentesP, string idAntecedentesF, 
            string idAntecedentesQ, string codDiagnostico, string fechaRegistro)
        {
            DataRow fila = datos.TraerDataRow("spActualizarHistoria", idHistoria, peso, talla, motivo,
                                sintomas, adicciones, motivoConsulta, idPaciente,
                                idDoctor, idUsuario, idHospital, idAntecedentesP,
                                idAntecedentesF, idAntecedentesQ, codDiagnostico, fechaRegistro);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }


        public string[] Agregar(string idHistoria, string peso, string talla, string motivo, 
            string sintomas, string adicciones, string motivoConsulta, string idPaciente, string idDoctor, 
            string idUsuario, string idHospital, string idAntecedentesP, string idAntecedentesF, string idAntecedentesQ, 
            string codDiagnostico, string fechaRegistro)
        {
            DataRow fila = datos.TraerDataRow("spAddHistoria", idHistoria, peso, talla, motivo,
                                sintomas, adicciones, motivoConsulta, idPaciente,
                                idDoctor, idUsuario, idHospital, idAntecedentesP,
                                idAntecedentesF, idAntecedentesQ, codDiagnostico, fechaRegistro);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        //public string[] Buscar(string idHistoria)
        //{
        //    DataRow fila = datos.TraerDataRow("spBuscarHistoria", idHistoria);
        //    //traer el codigo de error y el mensaje
        //    byte codError = Convert.ToByte(fila["CodError"]);

        //    mensaje = fila["Mensaje"].ToString();
        //    string[] aea = { mensaje, codError.ToString() };
        //    return aea;
        //}

        public string[] Eliminar(string idHistoria)
        {
            DataRow fila = datos.TraerDataRow("spEliminarHistoria", idHistoria);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        public DataSet Listar()
        {
            //throw new NotImplementedException();
            return datos.TraerDataSet("spListarHistoria");
        }

        public DataSet Buscar(string idHistoria)
        {
            return datos.TraerDataSet("spBuscarHistoria", idHistoria);
        }
    }
}
