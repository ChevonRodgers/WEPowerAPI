using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmFeeind
    {
        public PrmFeeind()
        {
            PrmFeetbl = new HashSet<PrmFeetbl>();
            PrmTrfind = new HashSet<PrmTrfind>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public decimal Status { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<PrmFeetbl> PrmFeetbl { get; set; }
        public virtual ICollection<PrmTrfind> PrmTrfind { get; set; }
    }
}
