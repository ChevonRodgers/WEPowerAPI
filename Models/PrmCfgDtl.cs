using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmCfgDtl
    {
        public decimal Id { get; set; }
        public decimal CfgId { get; set; }
        public decimal Type { get; set; }
        public decimal Status { get; set; }
        public string Scheme { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
    }
}
