using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmSupplier
    {
        public PrmSupplier()
        {
            AchvSim = new HashSet<AchvSim>();
            PrmMetertype = new HashSet<PrmMetertype>();
            PrmTmltype = new HashSet<PrmTmltype>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Http { get; set; }
        public string Address { get; set; }
        public string Descr { get; set; }
        public string BizContactPerson { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<AchvSim> AchvSim { get; set; }
        public virtual ICollection<PrmMetertype> PrmMetertype { get; set; }
        public virtual ICollection<PrmTmltype> PrmTmltype { get; set; }
    }
}
