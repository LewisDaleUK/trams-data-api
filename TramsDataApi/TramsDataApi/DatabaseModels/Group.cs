﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TramsDataApi.DatabaseModels
{
    public partial class Group
    {
        public string GroupUid { get; set; }
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public string CompaniesHouseNumber { get; set; }
        public string GroupTypeCode { get; set; }
        public string GroupType { get; set; }
        public string ClosedDate { get; set; }
        public string GroupStatusCode { get; set; }
        public string GroupStatus { get; set; }
        public string GroupContactStreet { get; set; }
        public string GroupContactLocality { get; set; }
        public string GroupContactAddress3 { get; set; }
        public string GroupContactTown { get; set; }
        public string GroupContactCounty { get; set; }
        public string GroupContactPostcode { get; set; }
        public string HeadOfGroupTitle { get; set; }
        public string HeadOfGroupFirstName { get; set; }
        public string HeadOfGroupLastName { get; set; }
        public string Ukprn { get; set; }
        public string IncorporatedOnOpenDate { get; set; }
        public string OpenDate { get; set; }
    }
}
