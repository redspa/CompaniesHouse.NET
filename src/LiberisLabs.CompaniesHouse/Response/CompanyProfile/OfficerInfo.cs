using System;
using Newtonsoft.Json;

namespace LiberisLabs.CompaniesHouse.Response.CompanyProfile
{
    public class OfficerInfo
    {
        [JsonProperty(PropertyName ="appointed_on")]
        public DateTime AppointedOn { get; set; }

        [JsonProperty(PropertyName ="name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName ="officer_role")]
        public string OfficerRole { get; set; }
    }
}