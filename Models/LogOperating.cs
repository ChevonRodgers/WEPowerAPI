using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogOperating
    {
        public string SessionId { get; set; }
        public DateTime? Crton { get; set; }
        public decimal? Crtby { get; set; }
        public string Url { get; set; }
        public string Ip { get; set; }
        public string Forms { get; set; }
        public decimal? Type { get; set; }
        public string Descr { get; set; }

        public virtual SysUser CrtbyNavigation { get; set; }
    }
}
