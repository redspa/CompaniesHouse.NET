using System;
using LiberisLabs.CompaniesHouse.Request;

namespace LiberisLabs.CompaniesHouse.UriBuilders
{
    public interface IOfficerListUriBuilder
    {
        Uri Build(OfficerListRequest request);
    }
}