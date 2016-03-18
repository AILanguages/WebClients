
using System.Runtime.Serialization;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class ChangeSampleSettingsRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public SampleSettings Settings { get; set; }
    }
}
