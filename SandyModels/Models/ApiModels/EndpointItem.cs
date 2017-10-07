using System;
using System.Runtime.Serialization;

namespace SandyModels.Models.ApiModels
{
    [DataContract]
    public class EndPointItem
    {
        [DataMember]
        public string HttpVerb { get; set; }
        [DataMember]
        public string Route { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string RequestBodyRequirements { get; set; }

        public EndPointItem(string verb, string route, string description, string requiredModelName = null)
        {
            HttpVerb = verb;
            Route = route;
            Description = description;

            if (!String.IsNullOrWhiteSpace(requiredModelName))
            {
                RequestBodyRequirements = $"This endpoint requires an object of type: {requiredModelName}";
            }
            else
            {
                RequestBodyRequirements = "This endpoint doesn't require an object in the request body";
            }
        }
    }
}
