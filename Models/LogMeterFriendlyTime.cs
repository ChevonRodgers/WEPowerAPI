using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogMeterFriendlyTime
    {
        public decimal? TrfIndId { get; set; }
        public decimal? TmlId { get; set; }
        public decimal? MeterId { get; set; }
        public decimal? Result { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? Mdfon { get; set; }
        public decimal? Mdfby { get; set; }
    }
}
