using Newtonsoft.Json;

namespace LiberisLabs.CompaniesHouse.Response.CompanyProfile
{
    public class AccountingReferenceDateInfo
    {
        [JsonProperty(PropertyName ="day")]
        public int Day { get; set; }

        [JsonProperty(PropertyName = "month")]
        public int Month { get; set; }

        public string DayAndMonth => $"{Day}/{Month}";
    }
}