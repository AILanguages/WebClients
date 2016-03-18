using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class ChangeScreenRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public int Selection { get; set; }

        [DataMember]
        public int Type { get; set; }

        [DataMember]
        public int Part { get; set; }
    }
}
