using System;
using Newtonsoft.Json;

namespace LiberisLabs.CompaniesHouse.Response.CompanyProfile
{
    public class AccountsInfo
    {
        [JsonProperty(PropertyName ="next_due")]
        public DateTime NextDue { get; set; }

        [JsonProperty(PropertyName ="next_made_up_to")]
        public DateTime NextMadeUpTo { get; set; }

        [JsonProperty(PropertyName = "overdue")]
        public bool Overdue { get; set; }

        [JsonProperty(PropertyName = "last_accounts")]
        public LastAccountsInfo LastAccounts { get; set; }

        [JsonProperty(PropertyName = "accounting_reference_date")]
        public AccountingReferenceDateInfo AccountingReferenceDate { get; set; }

      
    }
}