using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IDoctor
    {
        DataSet listar();
        string[] Agregar(string idDoctor, string nombre, string apellidoPaterno, string apellidoMaterno, string Especialidad,
                            string direccion, string telefono, string idHospital);
        string[] Actualizar(string idDoctor, string nombre, string apellidoPaterno, string apellidoMaterno, string Especialidad,
                            string direccion, string telefono, string idHospital);
        string[] Eliminar(string idDoctor);
        DataSet Buscar(string idDoctor);
    }
}
