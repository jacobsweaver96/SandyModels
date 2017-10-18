using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace SandyModels.Models.ApiModels
{
    [DataContract]
    public class ApiResponse<T>
    {
        [DataMember]
        public T Content { get; set; } = default(T);
        [DataMember]
        public List<EndPointItem> EndPointItems { get; set; } = new List<EndPointItem>();

        public ApiResponse() { }
    }

    [DataContract]
    public class ApiResponse
    {
        [DataMember]
        public List<EndPointItem> EndPointItems { get; set; } = new List<EndPointItem>();

        public ApiResponse() { }
    }
}
