using System;
using LiberisLabs.CompaniesHouse.Request;

namespace LiberisLabs.CompaniesHouse.UriBuilders
{
    public interface ICompanyProfileUriBuilder
    {
        Uri Build(CompanyProfileRequest request);
    }
}