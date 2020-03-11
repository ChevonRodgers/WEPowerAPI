using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvUpgradeDevice
    {
        public decimal Id { get; set; }
        public decimal UpgradeId { get; set; }
        public decimal MtTmlId { get; set; }
        public decimal? MtTmlType { get; set; }
        public DateTime? UpgradeStartTime { get; set; }
        public DateTime? UpgradeEndTime { get; set; }
        public decimal? UpgradeResult { get; set; }
        public string UpgradeErr { get; set; }
        public decimal? UpgradeProgress { get; set; }
        public DateTime? Crton { get; set; }
        public decimal? Crtby { get; set; }
    }
}
