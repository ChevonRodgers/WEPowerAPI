using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmCollect
    {
        public PrmCollect()
        {
            AchvMeter = new HashSet<AchvMeter>();
            AchvTml = new HashSet<AchvTml>();
            PrmCollectPlan = new HashSet<PrmCollectPlan>();
        }

        public decimal Id { get; set; }
        public decimal CommProtocol { get; set; }
        public string Name { get; set; }
        public decimal Status { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<AchvMeter> AchvMeter { get; set; }
        public virtual ICollection<AchvTml> AchvTml { get; set; }
        public virtual ICollection<PrmCollectPlan> PrmCollectPlan { get; set; }
    }
}
