using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysNoticeUser
    {
        public decimal NoticeId { get; set; }
        public decimal UserId { get; set; }
        public decimal Status { get; set; }

        public virtual SysNotice Notice { get; set; }
        public virtual SysUser User { get; set; }
    }
}
