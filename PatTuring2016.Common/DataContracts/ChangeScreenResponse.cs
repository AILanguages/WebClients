using System.Runtime.Serialization;
using PatTuring2016.Common.ScreenModels.FullScreenModels;
using PatTuring2016.Common.ScreenModels.PartDisplays;

namespace PatTuring2016.Common.DataContracts
{
    [KnownType(typeof(FullScreenModel))]
    [KnownType(typeof(AbstractPartDisplay))]
    [DataContract]
    public class ChangeScreenResponse : Response
    {
        [DataMember]
        public string Screen { get; set; }
    }
}
