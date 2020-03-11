using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogManualTask
    {
        public decimal RtuId { get; set; }
        public string RtuNo { get; set; }
        public decimal DataitemId { get; set; }
        public string NextStartTime { get; set; }
        public string RelayToMeter { get; set; }
        public decimal CollectPlanId { get; set; }
        public string MeterNo { get; set; }
        public decimal? TaskStatus { get; set; }
        public string TaskInterval { get; set; }
        public decimal? RetryCount { get; set; }
        public decimal? MaxCount { get; set; }
        public DateTime? SavedbTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
