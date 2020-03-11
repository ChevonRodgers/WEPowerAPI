using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvTml
    {
        public decimal Id { get; set; }
        public string Sn { get; set; }
        public decimal Status { get; set; }
        public string Imei { get; set; }
        public decimal? TmltypeId { get; set; }
        public string AssetNo { get; set; }
        public decimal? PowerGridId { get; set; }
        public decimal? PrmCollectId { get; set; }
        public decimal? PrmDeviceId { get; set; }
        public decimal? SimId { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
        public decimal? PrmCfgId { get; set; }

        public virtual AchvPowergrid PowerGrid { get; set; }
        public virtual PrmCollect PrmCollect { get; set; }
        public virtual PrmDeviceDeleted PrmDevice { get; set; }
        public virtual PrmTmltype Tmltype { get; set; }
    }
}
