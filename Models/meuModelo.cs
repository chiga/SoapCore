using System.Runtime.Serialization;

namespace prjSoapCore.Models
{
    [DataContract]
    public class meuModelo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}