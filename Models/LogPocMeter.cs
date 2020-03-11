using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogPocMeter
    {
        public decimal? PocId { get; set; }
        public decimal? NewMeterId { get; set; }
        public decimal? NewMeterKwh { get; set; }
        public decimal? NewMeterKvarh { get; set; }
        public decimal? OldMeterId { get; set; }
        public decimal? OldMeterKwh { get; set; }
        public decimal? OldMeterKvarh { get; set; }
        public DateTime? OperatedOn { get; set; }
        public string OperatedBy { get; set; }
        public string Descr { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
    }
}
