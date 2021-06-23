using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CapaEntidad
{
    [DataContract]
    class AntecedentesPersonalesE
    {
        [DataMember]
        public string idAntecedenteP { get; set; }

        [DataMember]
        public string relacionesSexuales { get; set; }

        [DataMember]
        public string edadSexInicio { get; set; }

        [DataMember]
        public string sexFrecuencia { get; set; }

        [DataMember]
        public string nroParejas { get; set; }

        [DataMember]
        public string usasProteccion { get; set; }

        [DataMember]
        public string vacunaSarampion { get; set; }

        [DataMember]
        public string vacunaViruela { get; set; }

        [DataMember]
        public string vacunaRabia { get; set; }

        [DataMember]
        public string vacunaFiebreA { get; set; }

        [DataMember]
        public string vacunaHepatitis { get; set; }

        [DataMember]
        public string otrasVacunas { get; set; }

    }
}