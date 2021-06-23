using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace CapaEntidad
{
    [DataContract]
    public class AntecedentesFamiliaresE
    {
        [DataMember]
        public string idAntecedenteF { get; set; }

        [DataMember]
        public string diabetes { get; set; }

        [DataMember]
        public string cancer { get; set; }

        [DataMember]
        public string tuberculosis { get; set; }

        [DataMember]
        public string ipertencion { get; set; }

        [DataMember]
        public string sida { get; set; }

        [DataMember]
        public string covid { get; set; }

        [DataMember]
        public string otrasenfermedades { get; set; }

    }
}