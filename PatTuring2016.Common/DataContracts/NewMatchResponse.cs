using System;
using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class NewMatchResponse : Response 
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public string MenuType { get; set; }

        [DataMember]
        public DateTime ExpirationDate { get; set; }
    }
}
