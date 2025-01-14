﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TramsDataApi.DatabaseModels
{
    public partial class Sponsor
    {
        public string PRid { get; set; }
        public string Rid { get; set; }
        public string SponsorId { get; set; }
        public string SponsorsSponsorId { get; set; }
        public string SponsorsSponsorName { get; set; }
        public string SponsorsPreviousOrAlternativeName { get; set; }
        public string SponsorsCoSponsorOrEducationalPartner { get; set; }
        public string SponsorsSponsorStatus { get; set; }
        public string SponsorsSponsorCoordinator { get; set; }
        public string SponsorsLeadContactForSponsor { get; set; }
        public string SponsorsLeadRscRegion { get; set; }
        public string LeadRscRegion { get; set; }
        public string SponsorsKs2MatQualityAssessment { get; set; }
        public string SponsorsKs4MatQualityAssessment { get; set; }
        public string SponsorsOtherMatQualityAssessment { get; set; }
        public string SponsorsOtherMatQualityAssessmentType { get; set; }
        public string SponsorsOverallCapacityForTheAcademicYear { get; set; }
        public string SponsorsSponsorRestriction { get; set; }
        public DateTime? SponsorsSponsorPausedExitedDate { get; set; }
        public DateTime? SponsorsPauseReviewDate { get; set; }
        public string SponsorsLinkToWorkplaces { get; set; }
        public bool? SponsorsLoadOpenAcademiesWithThisSponsor { get; set; }
        public bool? SponsorsLoadPipelineAcademiesProvisionallyWithThisSponsor { get; set; }
        public bool? SponsorsLoadPrePipelineAcademiesProvisionallyWithThisSponsor { get; set; }
        public bool? SponsorsLoadOpenAcademiesProvisionallyWithThisSponsorThroughReSponsoring { get; set; }
        public string SponsorContactDetailsContactName { get; set; }
        public string SponsorContactDetailsContactPosition { get; set; }
        public string SponsorContactDetailsContactPhone { get; set; }
        public string SponsorContactDetailsContactEmail { get; set; }
        public string SponsorContactDetailsContactAddressLine1 { get; set; }
        public string SponsorContactDetailsContactAddressLine2 { get; set; }
        public string SponsorContactDetailsContactAddressLine3 { get; set; }
        public string SponsorContactDetailsContactTown { get; set; }
        public string SponsorContactDetailsContactCounty { get; set; }
        public string SponsorContactDetailsContactPostcode { get; set; }
        public string SponsorContactDetailsContactLa { get; set; }
        public string SponsorCharacteristicsSponsorType { get; set; }
        public string SponsorCharacteristicsSecondOrderSponsorType { get; set; }
        public string SponsorCharacteristicsSponsorEducationalInstitutionCharacteristic { get; set; }
        public string SponsorCharacteristicsSponsorExpertisePrimary { get; set; }
        public string SponsorCharacteristicsSponsorExpertisePru { get; set; }
        public string SponsorCharacteristicsSponsorExpertiseSecondary { get; set; }
        public string SponsorCharacteristicsSponsorExpertiseSpecial { get; set; }
        public string ApprovalSponsorStatus { get; set; }
        public DateTime? ApprovalWithdrawnDate { get; set; }
        public string ApprovalWithdrawalLedBy { get; set; }
        public DateTime? ApprovalLastContactDate { get; set; }
        public DateTime? ApprovalExpressionOfInterestDate { get; set; }
        public DateTime? ApprovalApplicationDate { get; set; }
        public DateTime? ApprovalApplicationApprovedDate { get; set; }
        public DateTime? ApprovalEfaDueDiligenceCheckDateSent { get; set; }
        public DateTime? ApprovalEfaDueDiligenceCheckDateCompleted { get; set; }
        public string ApprovalEfaDueDiligenceCheckStatus { get; set; }
        public string ApprovalEfaComments { get; set; }
        public string ApprovalDueDiligenceCheck { get; set; }
        public string ApprovalDueDiligenceComments { get; set; }
        public string ApprovalSponsorRecruitmentEventAttendedIfApplicable { get; set; }
        public DateTime? ManagementCapacityAndAssessmentReviewDate { get; set; }
        public string ManagementCapacityAndGradeAssessmentComments { get; set; }
        public string ManagementSponsorCoordinatorComments { get; set; }
        public string ManagementEngagementTypeEastOfEnglandAndNorthEastLondon { get; set; }
        public string ManagementCapacityEastOfEnglandAndNorthEastLondon { get; set; }
        public string ManagementEngagementTypeSouthEastAndSouthLondon { get; set; }
        public string ManagementCapacitySouthEastAndSouthLondon { get; set; }
        public string ManagementEngagementTypeNorthWestLondonAndSouthCentral { get; set; }
        public string ManagementCapacityNorthWestLondonAndSouthCentral { get; set; }
        public string ManagementEngagementTypeSouthWest { get; set; }
        public string ManagementCapacitySouthWest { get; set; }
        public string ManagementEngagementTypeNorth { get; set; }
        public string ManagementCapacityNorth { get; set; }
        public string ManagementEngagementTypeEastMidlandsAndHumber { get; set; }
        public string ManagementCapacityEastMidlandsAndHumber { get; set; }
        public string ManagementEngagementTypeWestMidlands { get; set; }
        public string ManagementCapacityWestMidlands { get; set; }
        public string ManagementEngagementTypeLancashireAndWestYorkshire { get; set; }
        public string ManagementCapacityLancashireAndWestYorkshire { get; set; }
        public string ManagementSponsorMeetingsWithMinistersDate { get; set; }
        public string ManagementSponsorMeetingsWithRscDate { get; set; }
        public string ManagementPriorityArea { get; set; }
        public string ManagementLocalAuthorityS { get; set; }
        public string LocalAuthoritiesActive { get; set; }
        public string LocalAuthoritiesProspective { get; set; }
        public string SponsorTemplateInformationSponsorOverview { get; set; }
        public string SponsorTemplateInformationKeyPeople { get; set; }
        public string SponsorTemplateInformationFinance { get; set; }
        public string SponsorTemplateInformationFuturePlans { get; set; }
        public string SponsorTemplateInformationIssues { get; set; }
        public string SponsorTemplateInformationGovernanceAndTrustBoardStructuresAndAccountabilityFramework { get; set; }
        public string SponsorTemplateInformationSchoolImprovementStrategy { get; set; }
        public string SponsorTemplateInformationCompanyNumber { get; set; }
    }
}
