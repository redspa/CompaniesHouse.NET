using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberisLabs.CompaniesHouse.Request
{
  public  class PagedSearchRequest 
    {

        public int? ItemsPerPage { get; set; }

        public int? StartIndex { get; set; }
    }
}
