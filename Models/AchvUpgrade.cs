using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvUpgrade
    {
        public decimal Id { get; set; }
        public string Title { get; set; }
        public decimal Status { get; set; }
        public decimal MtTmlType { get; set; }
        public decimal IsCommModule { get; set; }
        public string UpgradeFile { get; set; }
        public string UpgradeVersion { get; set; }
        public decimal CommProtocolId { get; set; }
        public DateTime UpgradeStartTime { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Crton { get; set; }
        public decimal Mdfby { get; set; }
        public DateTime Mdfon { get; set; }
    }
}
