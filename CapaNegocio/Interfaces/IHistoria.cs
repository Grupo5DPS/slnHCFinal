using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IHistoria
    {
        //Declara metodos para una clase (Herencia y polimorfismo)
        DataSet Listar();
        string[] Agregar(string idHistoria, string peso, string talla,
                      string motivo, string sintomas, string adicciones, string motivoConsulta,
                      string idPaciente, string idDoctor, string idUsuario, string idHospital,
                      string idAntecedentesP, string idAntecedentesF, string idAntecedentesQ, string codDiagnostico, string fechaRegistro);
        string[] Actualizar(string idHistoria, string peso, string talla,
                      string motivo, string sintomas, string adicciones, string motivoConsulta,
                      string idPaciente, string idDoctor, string idUsuario, string idHospital,
                      string idAntecedentesP, string idAntecedentesF, string idAntecedentesQ, string codDiagnostico, string fechaRegistro);
        string[] Eliminar(string idHistoria);
        DataSet Buscar(string idHistoria);
    }
}
