using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IHospital
    {
        //Declara metodos para una clase (Herencia y polimorfismo)
        DataSet Listar();
        string[] Agregar(string idHo, string nombreHospital, string direccion);
        string[] Actualizar(string idHo, string nombreHospital, string direccion);
        string[] Eliminar(string idHo);
        DataSet Buscar(string idHo);

    }
}
