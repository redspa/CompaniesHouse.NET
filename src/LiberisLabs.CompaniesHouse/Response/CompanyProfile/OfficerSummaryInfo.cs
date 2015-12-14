using Newtonsoft.Json;

namespace LiberisLabs.CompaniesHouse.Response.CompanyProfile
{
    public class OfficerSummaryInfo
    {
        [JsonProperty(PropertyName ="active_count")]
        public int ActiveCount { get; set; }

        [JsonProperty(PropertyName ="resigned_count")]
        public int ResignedCount { get; set; }

        [JsonProperty(PropertyName ="officers")]
        public OfficerInfo[] Officers { get; set; }
    }
}