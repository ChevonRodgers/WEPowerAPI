using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogLogin
    {
        public string SessionId { get; set; }
        public decimal? Crtby { get; set; }
        public DateTime? Crton { get; set; }
        public string Ip { get; set; }
        public string Type { get; set; }
        public string Browse { get; set; }
        public string Os { get; set; }

        public virtual SysUser CrtbyNavigation { get; set; }
    }
}
