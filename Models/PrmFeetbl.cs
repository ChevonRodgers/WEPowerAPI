using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmFeetbl
    {
        public decimal Id { get; set; }
        public decimal FeeIndId { get; set; }
        public decimal FeeType { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual PrmFeeind FeeInd { get; set; }
    }
}
