using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvSim
    {
        public decimal Id { get; set; }
        public decimal? SupplierId { get; set; }
        public string Simno { get; set; }
        public string Simiccid { get; set; }
        public decimal? Simmodel { get; set; }
        public string Simip { get; set; }
        public decimal? Simport { get; set; }
        public string Simapn { get; set; }
        public decimal Status { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual PrmSupplier Supplier { get; set; }
    }
}
