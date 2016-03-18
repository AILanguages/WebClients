
using System.Runtime.Serialization;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.Common.DataContracts
{
    [KnownType(typeof(Match))]
    [DataContract]
    public class GetTextResponse : Response
    {
        [DataMember]
        public string Screen { get; set; }

        [DataMember]
        public Match Match { get; set; }

        [DataMember]
        public bool EditFound { get; set; }
    }
}
