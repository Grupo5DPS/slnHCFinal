using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace CapaEntidad
{
    [DataContract]
    public class HistoriaE
    {
        [DataMember]
        public string idHistoria { get; set; }

        [DataMember]
        public string peso { get; set; }

        [DataMember]
        public string talla { get; set; }

        [DataMember]
        public string motivo { get; set; }

        [DataMember]
        public string sintomas { get; set; }

        [DataMember]
        public string adicciones { get; set; }

        [DataMember]
        public string motivoConsulta { get; set; }

        [DataMember]
        public string idPaciente { get; set; }

        [DataMember]
        public string idDoctor { get; set; }

        [DataMember]
        public string idUsuario { get; set; }

        [DataMember]
        public string idHospital { get; set; }

        [DataMember]
        public string idAntecedentesP { get; set; }

        [DataMember]
        public string idAntecedentesF { get; set; }

        [DataMember]
        public string idAntecedentesQ { get; set; }

        [DataMember]
        public string codDiagnostico { get; set; }

        [DataMember]
        public string fechaRegistro { get; set; }
    }
}