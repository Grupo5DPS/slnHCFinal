using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization; // Serializar la clase p gaeaeae

namespace CapaEntidad
{
    [DataContract]
    public class HospitalE
    {
        [DataMember]
        public string idHo { get; set; }

        [DataMember]
        public string nombreHospital { get; set; }

        [DataMember]
        public string direccion { get; set; }

    }
}
