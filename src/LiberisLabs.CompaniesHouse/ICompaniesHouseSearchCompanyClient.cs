using System.Threading;
using System.Threading.Tasks;
using LiberisLabs.CompaniesHouse.Request;
using LiberisLabs.CompaniesHouse.Response.CompanySearch;
using LiberisLabs.CompaniesHouse.Response.CompanyProfile;
using LiberisLabs.CompaniesHouse.Response.OfficerList;

namespace LiberisLabs.CompaniesHouse
{
    public interface ICompaniesHouseSearchCompanyClient
    {
        Task<CompaniesHouseClientResponse<CompanySearch>> SearchCompanyAsync(CompanySearchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        Task<CompaniesHouseClientResponse<CompanyProfile>> CompanyProfileAsync(CompanyProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        Task<CompaniesHouseClientResponse<OfficerList>> OfficerListAsync(OfficerListRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}