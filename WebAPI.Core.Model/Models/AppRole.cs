using System;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Core.Model.Models
{
    public class AppRole : IdentityRole<int>
    {
        public bool? IsDeleted { get; set; }
        public string Description { get; set; }
        public int OrderSort { get; set; }
        public bool Enabled { get; set; }
        public int? CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; } = DateTime.Now;
        public int? ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; } = DateTime.Now;
    }
}
