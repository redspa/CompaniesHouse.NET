using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using LiberisLabs.CompaniesHouse.Request;
using LiberisLabs.CompaniesHouse.Response.CompanySearch;
using LiberisLabs.CompaniesHouse.Response.CompanyProfile;
using LiberisLabs.CompaniesHouse.UriBuilders;
using LiberisLabs.CompaniesHouse.Response.OfficerList;

namespace LiberisLabs.CompaniesHouse
{
    public class CompaniesHouseSearchCompanyClient : ICompaniesHouseSearchCompanyClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ICompanySearchUriBuilder _companySearchUriBuilder;
        private readonly ICompanyProfileUriBuilder _companyProfileUriBuilder;
        private readonly IOfficerListUriBuilder _officerListUriBuilder;

        public CompaniesHouseSearchCompanyClient(IHttpClientFactory httpClientFactory, ICompanySearchUriBuilder companySearchUriBuilder, ICompanyProfileUriBuilder companyProfileUriBuilder, IOfficerListUriBuilder officerListUriBuilder)
        {
            _httpClientFactory = httpClientFactory;
            _companySearchUriBuilder = companySearchUriBuilder;
            _companyProfileUriBuilder = companyProfileUriBuilder;
            _officerListUriBuilder = officerListUriBuilder;
        }

        public async Task<CompaniesHouseClientResponse<CompanySearch>> SearchCompanyAsync(CompanySearchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var httpClient = _httpClientFactory.CreateHttpClient())
            {
                var requestUri = _companySearchUriBuilder.Build(request);

                var response = await httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsAsync<CompanySearch>(cancellationToken).ConfigureAwait(false);

                return new CompaniesHouseClientResponse<CompanySearch>(result);
            }

        }

        public async Task<CompaniesHouseClientResponse<CompanyProfile>> CompanyProfileAsync(CompanyProfileRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var httpClient = _httpClientFactory.CreateHttpClient())
            {
                var requestUri = _companyProfileUriBuilder.Build(request);

                var response = await httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsAsync<CompanyProfile>(cancellationToken).ConfigureAwait(false);

                return new CompaniesHouseClientResponse<CompanyProfile>(result);
            }

        }

        public async Task<CompaniesHouseClientResponse<OfficerList>> OfficerListAsync(OfficerListRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var httpClient = _httpClientFactory.CreateHttpClient())
            {
                var requestUri = _officerListUriBuilder.Build(request);

                var response = await httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsAsync<OfficerList>(cancellationToken).ConfigureAwait(false);

                return new CompaniesHouseClientResponse<OfficerList>(result);
            }

        }
    }
}