using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysUserSubscribe
    {
        public decimal UserId { get; set; }
        public decimal? ViaEmail { get; set; }
        public decimal? ViaSms { get; set; }
        public decimal? ViaSystem { get; set; }
        public decimal? Event { get; set; }
        public decimal? Login { get; set; }
        public decimal? OrderReversal { get; set; }
        public decimal? MerchantCredit { get; set; }

        public virtual SysUser User { get; set; }
    }
}
