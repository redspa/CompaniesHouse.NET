using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberisLabs.CompaniesHouse.Response.OfficerList
{
    public class OfficerList : ListResult
    {
        [JsonProperty(PropertyName = "items")]
        public Officer[] Officers { get; set; }

        [JsonProperty(PropertyName = "active_count")]
        public int ActiveCount { get; set; }

        [JsonProperty(PropertyName ="resigned_count")]
        public int ResignedCount { get; set; }
    }
}
