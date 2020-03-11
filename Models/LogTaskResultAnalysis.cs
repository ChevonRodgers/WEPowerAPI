using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogTaskResultAnalysis
    {
        public DateTime Date { get; set; }
        public decimal? TotalTask { get; set; }
        public decimal? TotalMeter { get; set; }
        public decimal? TotalSuccess { get; set; }
        public decimal? AvgScd { get; set; }
        public decimal? MaxScd { get; set; }
        public decimal? MinScd { get; set; }
    }
}
