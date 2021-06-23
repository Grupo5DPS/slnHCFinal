using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization; // Serializar la clase p gaeaeae

namespace CapaEntidad
{
    [DataContract]
    public class DiagnosticosE
    {
        [DataMember]
        public string codDiagnostico { get; set; }

        [DataMember]
        public string descripcion { get; set; }

    }
}
