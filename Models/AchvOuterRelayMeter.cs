using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvOuterRelayMeter
    {
        public decimal Id { get; set; }
        public decimal OuterrelayId { get; set; }
        public decimal MeterId { get; set; }
        public decimal? RetryTimes { get; set; }
        public decimal? Result { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? Crton { get; set; }
        public decimal? Crtby { get; set; }
    }
}
