using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvPowergrid
    {
        public AchvPowergrid()
        {
            AchvLinelossPowergrid = new HashSet<AchvLinelossPowergrid>();
            AchvPoc = new HashSet<AchvPoc>();
            AchvTml = new HashSet<AchvTml>();
            SysUsergroupObj = new HashSet<SysUsergroupObj>();
        }

        public decimal Id { get; set; }
        public decimal? Pid { get; set; }
        public decimal? PowerGridType { get; set; }
        public string Sn { get; set; }
        public string Name { get; set; }
        public decimal? VoltageGrade { get; set; }
        public decimal? Status { get; set; }
        public string Lng { get; set; }
        public string Lat { get; set; }
        public string Descr { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<AchvLinelossPowergrid> AchvLinelossPowergrid { get; set; }
        public virtual ICollection<AchvPoc> AchvPoc { get; set; }
        public virtual ICollection<AchvTml> AchvTml { get; set; }
        public virtual ICollection<SysUsergroupObj> SysUsergroupObj { get; set; }
    }
}
