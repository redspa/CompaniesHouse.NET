using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberisLabs.CompaniesHouse.Request
{
    public class OfficerListRequest : PagedSearchRequest
    {
        public string CompanyNumber { get; set; }

        public string OrderBy { get; set; }
    }
}
