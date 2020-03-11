using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmMetertype
    {
        public PrmMetertype()
        {
            AchvMeter = new HashSet<AchvMeter>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal? SupplierId { get; set; }
        public string Descr { get; set; }
        public decimal? CommProtocol { get; set; }
        public decimal? CommType { get; set; }
        public string ConnectType { get; set; }
        public decimal IsCascade { get; set; }
        public decimal? Accuracy { get; set; }
        public decimal? VoltageGrade { get; set; }
        public decimal? CurrentGrade { get; set; }
        public decimal? CreditType { get; set; }
        public string VersionSoftware { get; set; }
        public string VersionHardware { get; set; }
        public decimal? KwhDecimalDigits { get; set; }
        public decimal? KvarhDecimalDigits { get; set; }
        public decimal? KvahDecimalDigits { get; set; }
        public decimal? KwDecimalDigits { get; set; }
        public decimal? KvarDecimalDigits { get; set; }
        public decimal? KvaDecimalDigits { get; set; }
        public decimal? PfDecimalDigits { get; set; }
        public decimal? ADecimalDigits { get; set; }
        public decimal? VDecimalDigits { get; set; }
        public decimal? HzDecimalDigits { get; set; }
        public decimal? CreditDecimalDigits { get; set; }
        public decimal? AngleDecimalDigits { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
        public decimal? WDecimalDigits { get; set; }
        public decimal? VarDecimalDigits { get; set; }

        public virtual PrmSupplier Supplier { get; set; }
        public virtual ICollection<AchvMeter> AchvMeter { get; set; }
    }
}
