using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class VndMchUser
    {
        public decimal MchId { get; set; }
        public decimal UserId { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }

        public virtual VndMch Mch { get; set; }
        public virtual SysUser User { get; set; }
    }
}
