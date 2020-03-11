using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataTmlOnline
    {
        public DateTime Date { get; set; }
        public decimal MtTmlId { get; set; }
        public decimal MtTmlType { get; set; }
        public decimal? OnlineTimes { get; set; }
        public decimal? OfflineTimes { get; set; }
        public decimal? OnlineMinutes { get; set; }
    }
}
