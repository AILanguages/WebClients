using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class GetSampleSettingsRequest
    {
        [DataMember]
        public string UserKey { get; set; }
    }
}
