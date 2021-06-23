using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using CapaEntidad;
namespace CapaNegocio.Interfaces
{
    interface IAntecedentesPersonales
    {
        DataSet Listar();
        string[] Agregar(string idAntecedenteP, string relacionesSexuales, string edadSexInicio, string sexFrecuencia, string nroParejas, string usasProteccion, string vacunaSarampion, string vacunaViruela, string vacunaRabia, string vacunaFiebreA, string vacunaHepatitis, string otrasVacunas);
        string[] Actualizar(string idAntecedenteP, string relacionesSexuales, string edadSexInicio, string sexFrecuencia, string nroParejas, string usasProteccion, string vacunaSarampion, string vacunaViruela, string vacunaRabia, string vacunaFiebreA, string vacunaHepatitis, string otrasVacunas);
        string[] Eliminar(string idAntecedenteP);
        DataSet Buscar(string idAntecedenteP);
    }
}
