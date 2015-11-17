using System;
using LiberisLabs.CompaniesHouse.Request;

namespace LiberisLabs.CompaniesHouse.UriBuilders
{
    public class OfficerListUriBuilder : IOfficerListUriBuilder
    {
        public Uri Build(OfficerListRequest request)
        {
            var path = $"company/{request.CompanyNumber}/officers";

            var query = $"?";

            if (request.ItemsPerPage.HasValue)
            {
                query += "&items_per_page=" + request.ItemsPerPage.Value;
            }

            if (request.StartIndex.HasValue)
            {
                query += "&start_index=" + request.StartIndex.Value;
            }

            if (!String.IsNullOrWhiteSpace(request.OrderBy))
            {
                query += "&order_by=" + request.OrderBy;
            }


            var pathAndQuery = path + query;

            return new Uri(pathAndQuery, UriKind.Relative);
        }
    }
}
