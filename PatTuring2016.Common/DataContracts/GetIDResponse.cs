using System;
using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class GetIDResponse : Response 
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public DateTime ExpirationDate { get; set; }
    }
}
