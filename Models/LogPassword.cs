using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogPassword
    {
        public decimal? UserId { get; set; }
        public string Password { get; set; }
        public DateTime? Crton { get; set; }
        public decimal? Crtby { get; set; }

        public virtual SysUser User { get; set; }
    }
}
