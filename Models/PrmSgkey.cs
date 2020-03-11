using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmSgkey
    {
        public decimal Id { get; set; }
        public decimal SgId { get; set; }
        public decimal Krn { get; set; }
        public decimal Ken { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? Baseline { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual PrmSg Sg { get; set; }
    }
}
