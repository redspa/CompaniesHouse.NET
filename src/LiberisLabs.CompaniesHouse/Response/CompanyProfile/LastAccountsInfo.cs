using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiberisLabs.CompaniesHouse.Response.CompanyProfile
{
    public class LastAccountsInfo {

        [JsonProperty(PropertyName = "made_up_to")]
        public DateTime MadeUpTo { get; set; }

        [JsonProperty(PropertyName ="type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AccountsType Type { get; set; }
    }
}