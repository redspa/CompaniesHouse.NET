namespace LiberisLabs.CompaniesHouse.Response.CompanyProfile
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Represents a Confirmation Statement associated with a <seealso cref="CompanyProfile"/>.
    /// </summary>
    public class ConfirmationStatementInfo
    {
        #region Properties

        [JsonProperty(PropertyName = "last_made_up_to")]
        public DateTime LastMadeUpTo { get; set; }

        [JsonProperty(PropertyName = "next_due")]
        public DateTime NextDue { get; set; }

        [JsonProperty(PropertyName = "next_made_up_to")]
        public DateTime NextMadeUpTo { get; set; }

        [JsonProperty(PropertyName = "overdue")]
        public bool Overdue { get; set; }

        #endregion
    }
}