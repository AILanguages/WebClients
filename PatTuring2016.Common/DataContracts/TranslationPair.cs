using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class TranslationPair
    {
        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public string Target { get; set; }
    }
}
