using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class GetTranslationRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public string TextIn { get; set; }
    }
}
