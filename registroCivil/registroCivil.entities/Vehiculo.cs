using System;
using System.Runtime.Serialization;

namespace registroCivil.entities
{
    [DataContract]
    public class Vehiculo
    {
        [DataMember]
        public long id_vehiculo { get; set; }
        [DataMember]
        public long id_propietario { get; set; }
        [DataMember]
        public string patente { get; set; }
        [DataMember]
        public string marca { get; set; }
        [DataMember]
        public string modelo { get; set; }
        [DataMember]
        public string version { get; set; }
        [DataMember]
        public int anio { get; set; }
    }
}
