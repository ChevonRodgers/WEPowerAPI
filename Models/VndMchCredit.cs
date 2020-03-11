using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class VndMchCredit
    {
        public decimal Id { get; set; }
        public decimal MchId { get; set; }
        public decimal Amount { get; set; }
        public string RefNo { get; set; }
        public decimal PayMethod { get; set; }
        public decimal Status { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual VndMch Mch { get; set; }
    }
}
