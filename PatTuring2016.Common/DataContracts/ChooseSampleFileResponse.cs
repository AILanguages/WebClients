using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class ChooseSampleFileResponse : Response 
    {
        [DataMember]
        public string Screen { get; set; }
    }
}
