using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberisLabs.CompaniesHouse.Response
{
    public class ListResult
    {
        [JsonProperty(PropertyName = "etag")]
        public string ETag { get; set; }

        [JsonProperty(PropertyName = "items_per_page")]
        public int? ItemsPerPage { get; set; }

        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        [JsonProperty(PropertyName = "page_number")]
        public int? PageNumber { get; set; }

        [JsonProperty(PropertyName = "start_index")]
        public int? StartIndex { get; set; }

        [JsonProperty(PropertyName = "total_results")]
        public int? TotalResults { get; set; }
    }
}
