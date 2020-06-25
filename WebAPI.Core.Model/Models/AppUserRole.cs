using System;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Core.Model.Models
{
    public class AppUserRole : IdentityUserRole<int>
    {
        public bool? IsDeleted { get; set; }
        public int? CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
