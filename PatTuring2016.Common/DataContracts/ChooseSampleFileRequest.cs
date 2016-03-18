using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class ChooseSampleFileRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public int Selection { get; set; }
    }
}
