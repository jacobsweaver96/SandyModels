using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace SandyModels.Models.ApiModels
{
    [DataContract]
    public class ApiResponse
    {
        [DataMember]
        public HttpStatusCode ResponseCode { get; set; }
        [DataMember]
        public object Content { get; set; }
        [DataMember]
        public string ContentType { get; set; } = "";
        [DataMember]
        public List<EndPointItem> EndPointItems { get; set; } = new List<EndPointItem>();

        public ApiResponse() { }
    }
}
