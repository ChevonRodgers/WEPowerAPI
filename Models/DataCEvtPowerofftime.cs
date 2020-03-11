using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataCEvtPowerofftime
    {
        public decimal MeterId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? SaveTime { get; set; }
        public decimal? PfCulTime { get; set; }
        public decimal? OffTimes { get; set; }
        public decimal? OnTimes { get; set; }
    }
}
