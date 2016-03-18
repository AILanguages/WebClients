using System.Runtime.Serialization;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.Common.DataContracts
{
    [KnownType(typeof(Match))]
    [DataContract]
    public class NewMatchRequest
    {
        [DataMember]
        public Match DataToMatch { get; set; }

        [DataMember]
        public string UserKey { get; set; }
    }
}
