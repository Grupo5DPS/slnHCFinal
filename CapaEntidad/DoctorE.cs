using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization; // Serializar la clase p gaeaeae

namespace CapaEntidad
{
    [DataContract]
    public class DoctorE
    {
        [DataMember]
        public string idDoctor { get; set; }

        [DataMember]
        public string nombre { get; set; }

        [DataMember]
        public string apellidoPaterno { get; set; }

        [DataMember]
        public string apellidoMaterno { get; set; }

        [DataMember]
        public string Especialidad { get; set; }

        [DataMember]
        public string direccion { get; set; }

        [DataMember]
        public string telefono { get; set; }

        [DataMember]
        public string idHospital { get; set; }
    }
}
