using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class OrdReversed
    {
        public decimal TrnId { get; set; }
        public decimal? OrderReversedReason { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
    }
}
