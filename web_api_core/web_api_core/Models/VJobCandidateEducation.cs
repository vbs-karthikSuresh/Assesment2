﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace web_api_core.Models
{
    public partial class VJobCandidateEducation
    {
        public int JobCandidateId { get; set; }
        public string EduLevel { get; set; }
        public DateTime? EduStartDate { get; set; }
        public DateTime? EduEndDate { get; set; }
        public string EduDegree { get; set; }
        public string EduMajor { get; set; }
        public string EduMinor { get; set; }
        public string EduGpa { get; set; }
        public string EduGpascale { get; set; }
        public string EduSchool { get; set; }
        public string EduLocCountryRegion { get; set; }
        public string EduLocState { get; set; }
        public string EduLocCity { get; set; }
    }
}
