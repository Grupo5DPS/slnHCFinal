using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization; // Serializar la clase p gaeaeae

namespace CapaEntidad
{   
    [DataContract]
    public class PacienteE
    {
       [DataMember]
        public string idPaciente { get; set; }

        [DataMember]
        public string nombre { get; set; }

        [DataMember]
        public string apellidoPaterno { get; set; }

        [DataMember]
        public string apellidoMaterno { get; set; }

        [DataMember]
        public string dni { get; set; }

        [DataMember]
        public string edad { get; set; }

        [DataMember]
        public string sexo { get; set; }

        [DataMember]
        public string fechaNacimiento { get; set; }

        [DataMember]
        public string estadoCivil { get; set; }

        [DataMember]
        public string ocupacion { get; set; }

        [DataMember]
        public string direccion { get; set; }

        [DataMember]
        public string telefono { get; set; }

        [DataMember]
        public string fechaIngreso { get; set; }
    }
}
