using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IDiagnostico
    {
        DataSet Listar();
        string[] Agregar(string codDiagnostico, string descripcion);
        string[] Actualizar(string codDiagnostico, string descripcion);
        string[] Eliminar(string codDiagnostico);
        DataSet Buscar(string codDiagnostico);
    }
}
