using Newtonsoft.Json;

namespace LiberisLabs.CompaniesHouse.Response.CompanySearch
{
    public class CompanySearch : ListResult
    {
       

        [JsonProperty(PropertyName = "items")]
        public Company[] Companies { get; set; }

   
    }
}