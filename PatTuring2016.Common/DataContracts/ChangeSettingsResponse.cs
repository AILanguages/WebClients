
using System.Runtime.Serialization;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.Common.DataContracts
{
    [KnownType(typeof(MatchSettings))]
    [DataContract]
    public class ChangeSettingsResponse : Response
    {
        [DataMember]
        public MatchSettings Settings { get; set; }
    }
}
