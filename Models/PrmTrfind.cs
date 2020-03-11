using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmTrfind
    {
        public PrmTrfind()
        {
            AchvPoc = new HashSet<AchvPoc>();
            PrmTrftbl = new HashSet<PrmTrftbl>();
        }

        public decimal Id { get; set; }
        public decimal? FeeIndId { get; set; }
        public decimal Ti { get; set; }
        public decimal? Type { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public decimal Status { get; set; }
        public string FriendlyTime { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual PrmFeeind FeeInd { get; set; }
        public virtual ICollection<AchvPoc> AchvPoc { get; set; }
        public virtual ICollection<PrmTrftbl> PrmTrftbl { get; set; }
    }
}
