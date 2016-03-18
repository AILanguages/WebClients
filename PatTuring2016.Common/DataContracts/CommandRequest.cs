using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class CommandRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public Command CommandNo { get; set; }
    }
}
