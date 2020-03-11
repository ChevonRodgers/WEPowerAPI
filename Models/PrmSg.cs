using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmSg
    {
        public PrmSg()
        {
            AchvPoc = new HashSet<AchvPoc>();
            PrmSgkey = new HashSet<PrmSgkey>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Sgc { get; set; }
        public string Descr { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<AchvPoc> AchvPoc { get; set; }
        public virtual ICollection<PrmSgkey> PrmSgkey { get; set; }
    }
}
