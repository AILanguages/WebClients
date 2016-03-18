using System.Collections.Generic;
using System.Runtime.Serialization;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.Common.DataContracts
{
    [KnownType(typeof(SampleMatchDisplay))]
    [KnownType(typeof(List<AnnotatedMatch>))]
    [KnownType(typeof(AnnotatedMatch))]
    [KnownType(typeof(Match))]
    [DataContract]
    public class SampleMatchResponse : Response 
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public SampleMatchDisplay SampleMatchDisplay { get; set; }
    }
}
