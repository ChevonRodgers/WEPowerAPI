using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysNotice
    {
        public SysNotice()
        {
            SysNoticeUser = new HashSet<SysNoticeUser>();
        }

        public decimal Id { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? Deadline { get; set; }
        public decimal NoticeAll { get; set; }
        public decimal? Hits { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<SysNoticeUser> SysNoticeUser { get; set; }
    }
}
