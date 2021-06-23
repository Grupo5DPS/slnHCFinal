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
    public class AntecedentesPersonales : Interfaces.IAntecedentesPersonales
    {
        private Datos datos = new DatosSQL();
        string mensaje;

        public string[] Actualizar(string idAntecedenteP, string relacionesSexuales, string edadSexInicio, string sexFrecuencia, string nroParejas, string usasProteccion, string vacunaSarampion, string vacunaViruela, string vacunaRabia, string vacunaFiebreA, string vacunaHepatitis, string otrasVacunas)
        {
            DataRow fila = datos.TraerDataRow("spActualizarAP",
            idAntecedenteP,
            relacionesSexuales,
            edadSexInicio,
            sexFrecuencia,
            nroParejas,
            usasProteccion,
            vacunaSarampion,
            vacunaViruela,
            vacunaRabia,
             vacunaFiebreA,
             vacunaHepatitis,
             otrasVacunas);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public string[] Agregar(string idAntecedenteP, string relacionesSexuales, string edadSexInicio, string sexFrecuencia, string nroParejas, string usasProteccion, string vacunaSarampion, string vacunaViruela, string vacunaRabia, string vacunaFiebreA, string vacunaHepatitis, string otrasVacunas)
        {
            DataRow fila = datos.TraerDataRow("spAddAntecedentesP",
                        idAntecedenteP,
                        relacionesSexuales,
                        edadSexInicio,
                        sexFrecuencia,
                        nroParejas,
                        usasProteccion,
                        vacunaSarampion,
                        vacunaViruela,
                        vacunaRabia,
                         vacunaFiebreA,
                         vacunaHepatitis,
                         otrasVacunas);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        //public string[] Buscar(string idAntecedenteP)
        //{
        //    DataRow fila = datos.TraerDataRow("spBuscarAntecedentesP", idAntecedenteP);
        //    byte codError = Convert.ToByte(fila["CodError"]);
        //    mensaje = fila["Mensaje"].ToString();
        //    string[] info = { mensaje, codError.ToString() };
        //    return info;
        //}

        public string[] Eliminar(string idAntecedenteP)
        {
            DataRow fila = datos.TraerDataRow("spEliminarAntecedentesP", idAntecedenteP);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] info = { mensaje, codError.ToString() };
            return info;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarAntecedentesPersonales");
        }

        public DataSet Buscar(string idAntecedenteP)
        {
            return datos.TraerDataSet("spBuscarAntecedentesP", idAntecedenteP);
        }
    }
}