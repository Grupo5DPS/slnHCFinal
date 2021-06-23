using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IAntecedentesFamiliares
    {
        DataSet Listar();
        string[] Agregar(string idAntecedenteF, string diabetes, string cancer, string tuberculosis, string ipertencion, string sida, string covid, string otrasenfermedades);
        string[] Actualizar(string idAntecedenteF, string diabetes, string cancer, string tuberculosis, string ipertencion, string sida, string covid, string otrasenfermedades);
        string[] Eliminar(string idAntecedenteF);
        DataSet Buscar(string idAntecedenteF);
    }
}
