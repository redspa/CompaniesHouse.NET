using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberisLabs.CompaniesHouse.Response.OfficerList
{
    public class CompaniesHouseDate
    {
        [JsonProperty(PropertyName="day")]
        public int Day { get; set; }
        [JsonProperty(PropertyName = "month")]
        public int Month { get; set; }
        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; }

      

    }
}
