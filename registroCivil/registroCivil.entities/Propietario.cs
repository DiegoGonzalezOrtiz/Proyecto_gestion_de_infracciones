using System.Runtime.Serialization;


namespace registroCivil.entities
{
    [DataContract]
    public class Propietario
    {
        [DataMember]
        public long id_propietario { get; set; }
        [DataMember]
        public string run { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string apellido_paterno { get; set; }
        [DataMember]
        public string apellido_materno { get; set; }
    }
}
