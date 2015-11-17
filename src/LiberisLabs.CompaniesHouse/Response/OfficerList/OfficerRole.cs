using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiberisLabs.CompaniesHouse.Response.OfficerList
{
    public enum OfficerRole
    {
        [EnumMember(Value = "cic-manager")]
        CICManager,

        [EnumMember(Value = "corporate-director")]
        CorporateDirector,

        [EnumMember(Value = "corporate-llp-designated-member")]
        CorporateLLPDesignatedMember,

        [EnumMember(Value = "corporate-llp-member")]
        CorporateLLPMember,

        [EnumMember(Value = "corporate-manager-of-an-eeig")]
        CorporateManagerOfAnEEIG,

        [EnumMember(Value = "corporate-member-of-a-management-organ")]
        CorporateMemberOfAMangagementOrgan,

        [EnumMember(Value = "corporate-member-of-a-supervisory-organ")]
        CorporateMemberOfASupervisoryOrgan,

        [EnumMember(Value = "corporate-member-of-an-administrative-organ")]
        CorporateMemberOfAnAdministrativeOrgan,

        [EnumMember(Value = "corporate-nominee-director")]
        CorporateNomineeDirector,

        [EnumMember(Value = "corporate-nominee-secretary")]
        CorporateNomineeSecretary,

        [EnumMember(Value = "corporate-secretary")]
        CorporateSecretary,

        [EnumMember(Value = "director")]
        Director,

        [EnumMember(Value = "general-partner-in-a-limited-partnership")]
        GeneralPartnerInALimitedPartnership,

        [EnumMember(Value = "judicial-factor")]
        JudicialFactor,

        [EnumMember(Value = "limited-partner-in-a-limited-partnership")]
        LimitedPartnerInALimitedPartnership,

        [EnumMember(Value = "llp-designated-member")]
        LLPDesignatedMember,

        [EnumMember(Value = "llp-member")]
        LLPMember,

        [EnumMember(Value = "manager-of-an-eeig")]
        ManagerOfAnEEIG,

        [EnumMember(Value = "member-of-a-management-organ")]
        MemberOfAManagementOrgan,

        [EnumMember(Value = "member-of-a-supervisory-organ")]
        MemberOfASupervisoryOrgan,

        [EnumMember(Value = "member-of-an-administrative-organ")]
        MemberOfAnAdministrativeOrgan,

        [EnumMember(Value = "nominee-director")]
        NomineeDirector,

        [EnumMember(Value = "nominee-secretary")]
        NomineeSecretary,

        [EnumMember(Value = "person-authorised-to-accept")]
        PersonAuthorisedToAccept,

        [EnumMember(Value = "person-authorised-to-represent")]
        PersonAuthorisedToRepresent,

        [EnumMember(Value = "person-authorised-to-represent-and-accept")]
        PersonAuthorisedToRepresentAndAccept,

        [EnumMember(Value = "receiver-and-manager")]
        ReceiverAndManager,

        [EnumMember(Value = "secretary")]
        Secretary
    }
}
