using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogMsg
    {
        public decimal Id { get; set; }
        public DateTime? Crton { get; set; }
        public decimal? Crtby { get; set; }
        public decimal? SendTo { get; set; }
        public string Msg { get; set; }
        public decimal? Status { get; set; }

        public virtual SysUser CrtbyNavigation { get; set; }
    }
}
