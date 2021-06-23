using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using CapaEntidad;
namespace CapaNegocio.Interfaces
{
    interface IAntecedentesQuirurjicos
    {
        DataSet Listar();
        string[] Agregar(string idAntecedenteQ, string tuvoIntervencion, string nroVeces, string causaOperacion, string alergias, string queAlergias, string sufreDiabetes, string sufreEpilepsia, string sufreHipertension, string otrasEnfermedades, string medicamentos, string queMedicamentos);
        string[] Actualizar(string idAntecedenteQ, string tuvoIntervencion, string nroVeces, string causaOperacion, string alergias, string queAlergias, string sufreDiabetes, string sufreEpilepsia, string sufreHipertension, string otrasEnfermedades, string medicamentos, string queMedicamentos);
        string[] Eliminar(string idAntecedenteQ);
        DataSet Buscar(string idAntecedenteQ);
    }
}
