using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogCommTime
    {
        public decimal MtTmlId { get; set; }
        public decimal MtTmlType { get; set; }
        public DateTime LatestTime { get; set; }
    }
}
