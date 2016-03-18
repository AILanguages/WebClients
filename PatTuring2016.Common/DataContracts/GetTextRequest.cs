using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class GetTextRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public string TextIn { get; set; }

        [DataMember]
        public int Selection { get; set; }

        [DataMember]
        public int Type { get; set; }
    }
}
