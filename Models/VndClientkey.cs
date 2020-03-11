using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class VndClientkey
    {
        public decimal Id { get; set; }
        public string ClientKey { get; set; }
        public string MachineId { get; set; }
        public decimal? LimitType { get; set; }
        public decimal? LimitCduId { get; set; }
        public decimal? LimitUserId { get; set; }
        public DateTime? RegOn { get; set; }
        public decimal? RegBy { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime? Mdfon { get; set; }
        public decimal? Mdfby { get; set; }
    }
}
