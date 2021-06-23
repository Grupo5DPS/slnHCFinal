using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaEntidad;


namespace CapaNegocio.Interfaces
{
    interface IUser
    {
        DataSet Listar();
        string[] Agregar(string idUsuario, string usuario,string contrasenia);
        string[] Actualizar(string idUsuario, string usuario, string contrasenia);
        string[] Eliminar(string idUsuario);
        DataSet Buscar(string idUsuario);

    }
}
