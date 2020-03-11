using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvThreshold
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal? ActivePowerOver { get; set; }
        public decimal? ApOverTime { get; set; }
        public decimal? ReactivePowerOver { get; set; }
        public decimal? RpOverTime { get; set; }
        public decimal? CurrentOver { get; set; }
        public decimal? COverTime { get; set; }
        public decimal? CurrentUnder { get; set; }
        public decimal? CUnderTime { get; set; }
        public decimal? VoltageOver { get; set; }
        public decimal? VOverTime { get; set; }
        public decimal? VoltageUnder { get; set; }
        public decimal? VUnderTime { get; set; }
        public decimal? CurrentImbalance { get; set; }
        public decimal? CImbalanceTime { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime? Mdfon { get; set; }
        public decimal? Mdfby { get; set; }
        public decimal? Protocol { get; set; }
        public decimal? PowerFactorUnder { get; set; }
        public decimal? PfUnderTime { get; set; }
        public decimal? CurrentBypass { get; set; }
        public decimal? CBypassTime { get; set; }
        public decimal? PfAunder { get; set; }
        public decimal? PfAunderTime { get; set; }
        public decimal? PfBunder { get; set; }
        public decimal? PfBunderTime { get; set; }
        public decimal? PfCunder { get; set; }
        public decimal? PfCunderTime { get; set; }
    }
}
