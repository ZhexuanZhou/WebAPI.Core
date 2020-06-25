using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Core.Model.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string LoginName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; } = DateTime.Now;
        public DateTime LastErrTime { get; set; } = DateTime.Now;
        public int ErrorCount { get; set; }
        public int Sex { get; set; } = 0;
        public int Age { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
        public string Addr { get; set; }
        public bool TdIsDelete { get; set; }
    }
}
