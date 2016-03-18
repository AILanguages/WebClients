
using System.Collections.Generic;
using System.Runtime.Serialization;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.Common.DataContracts
{
    [KnownType(typeof(TranslatePair))]
    [DataContract]
    public class GetTranslationResponse : Response
    {
        [DataMember]
        public List<TranslationPair> TranslationPair { get; set; }
    }
}
