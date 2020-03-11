using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogMeterstatus
    {
        public decimal? MeterId { get; set; }
        public decimal? Status { get; set; }
        public decimal? Kwh { get; set; }
        public decimal? Kvarh { get; set; }
        public DateTime? OperatedOn { get; set; }
        public string OperatedBy { get; set; }
        public string Descr { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
    }
}
