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
    public class AntecedentesQuirurjicos : Interfaces.IAntecedentesQuirurjicos
    {
        private Datos datos = new DatosSQL();
        string mensaje;

        public string[] Actualizar(string idAntecedenteQ, string tuvoIntervencion, string nroVeces, string causaOperacion, string alergias, string queAlergias, string sufreDiabetes, string sufreEpilepsia, string sufreHipertension, string otrasEnfermedades, string medicamentos, string queMedicamentos)
        {
            DataRow fila = datos.TraerDataRow("spActualizarAQ",
                idAntecedenteQ,
                tuvoIntervencion,
                nroVeces,
                causaOperacion,
                alergias,
                queAlergias,
                sufreDiabetes,
                sufreEpilepsia,
                sufreHipertension,
                otrasEnfermedades,
                medicamentos,
                queMedicamentos);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public string[] Agregar(string idAntecedenteQ, string tuvoIntervencion, string nroVeces, string causaOperacion, string alergias, string queAlergias, string sufreDiabetes, string sufreEpilepsia, string sufreHipertension, string otrasEnfermedades, string medicamentos, string queMedicamentos)
        {
            DataRow fila = datos.TraerDataRow("spAddAntecedentesQ",
               idAntecedenteQ,
               tuvoIntervencion,
               nroVeces,
               causaOperacion,
               alergias,
               queAlergias,
               sufreDiabetes,
               sufreEpilepsia,
               sufreHipertension,
               otrasEnfermedades,
               medicamentos,
               queMedicamentos);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        //public string[] Buscar(string idAntecedenteQ)
        //{
        //    DataRow fila = datos.TraerDataRow("spBuscarAntecedentesQ", idAntecedenteQ);
        //    byte codError = Convert.ToByte(fila["CodError"]);
        //    mensaje = fila["Mensaje"].ToString();
        //    string[] info = { mensaje, codError.ToString() };
        //    return info;
        //}

        public string[] Eliminar(string idAntecedenteQ)
        {
            DataRow fila = datos.TraerDataRow("spEliminarAntecedentesQ", idAntecedenteQ);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarAntecedentesQuirurjicos");
        }

        public DataSet Buscar(string idAntecedenteQ)
        {
            return datos.TraerDataSet("spBuscarAntecedentesQ", idAntecedenteQ);
        }
    }
}