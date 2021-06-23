    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IPaciente
    {
        //Declara metodos para una clase (Herencia y polimorfismo)
        DataSet Listar();
        string[] Agregar(string idPaciente, string nombre, string apellidoPaterno, 
                      string apellidoMaterno, string dni, string edad, 
                    string sexo, string fechaNacimiento, string estadoCivil, string ocupacion, string direccion,
                    string telefono, string fechaIngreso);
        string[] Actualizar(string idPaciente, string nombre, string apellidoPaterno,
                      string apellidoMaterno, string dni, string edad,
                    string sexo, string fechaNacimiento, string estadoCivil, string ocupacion, string direccion,
                    string telefono, string fechaIngreso);
        string[] Eliminar(string idPaciente);
        DataSet Buscar(string idPaciente);
    }
}
