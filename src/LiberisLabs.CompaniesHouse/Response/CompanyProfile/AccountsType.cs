using System.Runtime.Serialization;

namespace LiberisLabs.CompaniesHouse.Response.CompanyProfile
{
    public enum AccountsType
    {
        [EnumMember(Value = "null")]
        None = 0,
        [EnumMember(Value = "full")]
        Full,
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "dormant")]
        Dormant,
        [EnumMember(Value = "interim")]
        Interim,
        [EnumMember(Value = "initial")]
        Initial,
        [EnumMember(Value = "total-exemption-full")]
        TotalExcemptionFull,
        [EnumMember(Value = "total-exemption-small")]
        TotalExcemptionSmall,
        [EnumMember(Value = "partial-exemption")]
        PartialExcemption,
        [EnumMember(Value = "audit-exemption-subsidiary")]
        AuditExemptionSubsidiary,
        [EnumMember(Value = "filing-exemption-subsidiary")]
        FilingExemptionSubsidiary,
        [EnumMember(Value = "micro-entity")]
        MicroEntity
    }
}
