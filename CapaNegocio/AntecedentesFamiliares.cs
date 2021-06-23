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
    public class AntecedentesFamiliares : Interfaces.IAntecedentesFamiliares
    {
        private Datos datos = new DatosSQL();
        string mensaje;

        public string[] Actualizar(string idAntecedenteF, string diabetes, string cancer, string tuberculosis, string ipertencion, string sida, string covid, string otrasenfermedades)
        {
            DataRow fila = datos.TraerDataRow("spActualizarAF",
                         idAntecedenteF,
                         diabetes,
                         cancer,
                         tuberculosis,
                         ipertencion,
                         sida,
                         covid,
                         otrasenfermedades);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public string[] Agregar(string idAntecedenteF, string diabetes, string cancer, string tuberculosis, string ipertencion, string sida, string covid, string otrasenfermedades)
        {
            DataRow fila = datos.TraerDataRow("spAddAntecedentesF",
                                   idAntecedenteF,
                                   diabetes,
                                   cancer,
                                   tuberculosis,
                                   ipertencion,
                                   sida,
                                   covid,
                                   otrasenfermedades);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        //public string[] Buscar(string idAntecedenteF)
        //{
        //    DataRow fila = datos.TraerDataRow("spBuscarAntecedentesF", idAntecedenteF);
        //    byte codError = Convert.ToByte(fila["CodError"]);
        //    mensaje = fila["Mensaje"].ToString();
        //    string[] info = { mensaje, codError.ToString() };
        //    return info;
        //}

        public string[] Eliminar(string idAntecedenteF)
        {
            DataRow fila = datos.TraerDataRow("spEliminarAntecedentesF", idAntecedenteF);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarAntecedentesFamiliares");
        }

        public DataSet Buscar(string idAntecedenteF)
        {
            return datos.TraerDataSet("spBuscarAntecedentesF", idAntecedenteF);
        }
    }
}