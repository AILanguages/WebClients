﻿using System.Runtime.Serialization;

namespace PatTuring2016.Common.DataContracts
{
    [DataContract]
    public class GetScreenRequest
    {
        [DataMember]
        public string UserKey { get; set; }
    }
}
