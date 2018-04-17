using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace registroCivil.entities
{
    [DataContract]
    public class PropietarioFull
    {
        [DataMember]
        public Propietario propietario { get; set; }
        [DataMember]
        public List<Vehiculo> vehiculoList { get; set; }
    }
}
