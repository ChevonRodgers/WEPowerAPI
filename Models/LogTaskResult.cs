using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogTaskResult
    {
        public decimal MtTmlId { get; set; }
        public decimal MtTmlType { get; set; }
        public string TaskType { get; set; }
        public DateTime ExecuteTime { get; set; }
        public decimal Result { get; set; }
        public decimal? Times { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
