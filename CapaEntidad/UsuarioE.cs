using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization; // Serializar la clase p gaeaeae

namespace CapaEntidad
{
    [DataContract]
    public class UsuarioE
    {
        [DataMember]
        public string idUsuario { get; set; }

        [DataMember]
        public string usuario { get; set; }

        [DataMember]
        public string contrasenia { get; set; }

    }
}
