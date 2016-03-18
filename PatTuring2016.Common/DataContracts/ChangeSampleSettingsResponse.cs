
using System.Runtime.Serialization;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.Common.DataContracts
{
    [KnownType(typeof(SampleSettings))]
    [DataContract]
    public class ChangeSampleSettingsResponse : Response
    {
        [DataMember]
        public SampleSettings Settings { get; set; }
    }
}
