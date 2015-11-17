using System;
using LiberisLabs.CompaniesHouse.Request;

namespace LiberisLabs.CompaniesHouse.UriBuilders
{
    public class CompanyProfileUriBuilder : ICompanyProfileUriBuilder
    {
        public Uri Build(CompanyProfileRequest request)
        {
            var path = "company/";

            var query = request.CompanyNumber;

            var pathAndQuery = path + query;

            return new Uri(pathAndQuery, UriKind.Relative);
        }
    }
}
