﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace web_api_core.Models
{
    public partial class AmanEmp
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
