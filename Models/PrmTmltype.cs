using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmTmltype
    {
        public PrmTmltype()
        {
            AchvTml = new HashSet<AchvTml>();
        }

        public decimal Id { get; set; }
        public decimal? SupplierId { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public decimal? CommProtocol { get; set; }
        public decimal? CommType { get; set; }
        public decimal? MeterCommType { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual PrmSupplier Supplier { get; set; }
        public virtual ICollection<AchvTml> AchvTml { get; set; }
    }
}
