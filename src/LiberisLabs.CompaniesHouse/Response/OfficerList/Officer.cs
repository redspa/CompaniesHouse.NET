using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberisLabs.CompaniesHouse.Response.OfficerList
{
    public class Officer
    {
        [JsonProperty(PropertyName="name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName ="address")]
        public CompanySearch.Address Address { get; set; }

        [JsonProperty(PropertyName ="appointed_on")]
        public DateTime AppointedOn { get; set; }

        [JsonProperty(PropertyName="country_of_residence")]
        public string CountryOfResidence { get; set; }

        [JsonProperty(PropertyName ="date_of_birth")]
        public CompaniesHouseDate DateOfBirth { get; set; }

        [JsonProperty(PropertyName ="nationality")]
        public string Nationality { get; set; }

        [JsonProperty(PropertyName ="occupation")]
        public string Occupation { get; set; }

        [JsonProperty(PropertyName ="officer_role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OfficerRole OfficerRole { get; set; }

        [JsonProperty(PropertyName ="resigned_on")]
        public DateTime ResignedOn { get; set; }


    }
}
