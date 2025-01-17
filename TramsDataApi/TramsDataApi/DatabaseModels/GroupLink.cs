﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TramsDataApi.DatabaseModels
{
    public partial class GroupLink
    {
        public string Urn { get; set; }
        public string GroupUid { get; set; }
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public string CompaniesHouseNumber { get; set; }
        public string GroupTypeCode { get; set; }
        public string GroupType { get; set; }
        public string ClosedDate { get; set; }
        public string GroupStatusCode { get; set; }
        public string GroupStatus { get; set; }
        public string JoinedDate { get; set; }
        public string EstablishmentName { get; set; }
        public string TypeOfEstablishmentCode { get; set; }
        public string TypeOfEstablishmentName { get; set; }
        public string PhaseOfEducationCode { get; set; }
        public string PhaseOfEducationName { get; set; }
        public string LaCode { get; set; }
        public string LaName { get; set; }
        public string IncorporatedOnOpenDate { get; set; }
        public string OpenDate { get; set; }
    }
}
