using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmDeviceDeleted
    {
        public PrmDeviceDeleted()
        {
            AchvMeter = new HashSet<AchvMeter>();
            AchvTml = new HashSet<AchvTml>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Status { get; set; }
        public string Server { get; set; }
        public decimal Port { get; set; }
        public string Descr { get; set; }
        public DateTime? Crton { get; set; }
        public decimal? Crtby { get; set; }
        public DateTime? Mdfon { get; set; }
        public decimal? Mdfby { get; set; }

        public virtual ICollection<AchvMeter> AchvMeter { get; set; }
        public virtual ICollection<AchvTml> AchvTml { get; set; }
    }
}
