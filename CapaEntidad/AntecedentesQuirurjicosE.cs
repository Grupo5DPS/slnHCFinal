using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization; // Serializar la clase p gaeaeae

namespace CapaEntidad
{
    [DataContract]
    public class AntecedentesQuirurjicosE
    {
        [DataMember]
        public string idAntecedenteQ { get; set; }

        [DataMember]
        public string tuvoIntervencion { get; set; }

        [DataMember]
        public string nroVeces { get; set; }

        [DataMember]
        public string causaOperacion { get; set; }

        [DataMember]
        public string alergias { get; set; }

        [DataMember]
        public string queAlergias { get; set; }

        [DataMember]
        public string sufreDiabetes { get; set; }

        [DataMember]
        public string sufreEpilepsia { get; set; }

        [DataMember]
        public string sufreHipertension { get; set; }

        [DataMember]
        public string otrasEnfermedades { get; set; }

        [DataMember]
        public string medicamentos { get; set; }

        [DataMember]
        public string queMedicamentos { get; set; }

    }
}
