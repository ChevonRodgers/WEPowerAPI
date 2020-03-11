using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogTmlTask
    {
        public string RtuNo { get; set; }
        public string MeterNo { get; set; }
        public string DataitemId { get; set; }
        public decimal TmlId { get; set; }
        public DateTime? NextTaskTime { get; set; }
        public decimal? NextTaskPtNo { get; set; }
    }
}
