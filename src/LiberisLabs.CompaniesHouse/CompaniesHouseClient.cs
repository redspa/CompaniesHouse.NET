using System.Threading;
using System.Threading.Tasks;
using LiberisLabs.CompaniesHouse.Request;
using LiberisLabs.CompaniesHouse.Response.CompanySearch;
using LiberisLabs.CompaniesHouse.Response.CompanyProfile;
using LiberisLabs.CompaniesHouse.UriBuilders;
using LiberisLabs.CompaniesHouse.Response.OfficerList;

namespace LiberisLabs.CompaniesHouse
{
    public class CompaniesHouseClient : ICompaniesHouseClient
    {
        private readonly ICompaniesHouseSearchCompanyClient _companiesHouseSearchCompanyClient;

        public CompaniesHouseClient(ICompaniesHouseSettings settings)
        {
            var httpClientFactory = new HttpClientFactory(settings);

            _companiesHouseSearchCompanyClient = new CompaniesHouseSearchCompanyClient(httpClientFactory, new CompanySearchUriBuilder(), new CompanyProfileUriBuilder(), new OfficerListUriBuilder());
        }

        public Task<CompaniesHouseClientResponse<CompanySearch>> SearchCompanyAsync(CompanySearchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseSearchCompanyClient.SearchCompanyAsync(request, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<CompanyProfile>> CompanyProfileAsync(CompanyProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseSearchCompanyClient.CompanyProfileAsync(request, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<OfficerList>> OfficerListAsync(OfficerListRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseSearchCompanyClient.OfficerListAsync(request, cancellationToken);
        }
    }
}
