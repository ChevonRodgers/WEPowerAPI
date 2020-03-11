using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvMeter
    {
        public AchvMeter()
        {
            AchvLoadctrlMeter = new HashSet<AchvLoadctrlMeter>();
            AchvPoc = new HashSet<AchvPoc>();
        }

        public decimal Id { get; set; }
        public string Msno { get; set; }
        public decimal Status { get; set; }
        public decimal? MeterTypeId { get; set; }
        public decimal? PrmCollectId { get; set; }
        public decimal? PrmDeviceId { get; set; }
        public decimal? SimId { get; set; }
        public string AssetNo { get; set; }
        public string Descr { get; set; }
        public decimal? Krn { get; set; }
        public decimal? Ti { get; set; }
        public decimal? Ken { get; set; }
        public decimal? Sgc { get; set; }
        public DateTime? LastVending { get; set; }
        public DateTime? LastFreeVending { get; set; }
        public decimal CurrentMonthUnits { get; set; }
        public decimal CurrentMonthMoney { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
        public decimal? Dlmsauthentication { get; set; }
        public string Dlmspassword { get; set; }
        public decimal? Dlmsaesgcm128 { get; set; }
        public string Dlmsak { get; set; }
        public string Dlmsek { get; set; }
        public decimal? IsRegister { get; set; }
        public decimal? PrmCfgId { get; set; }

        public virtual PrmMetertype MeterType { get; set; }
        public virtual PrmCollect PrmCollect { get; set; }
        public virtual PrmDeviceDeleted PrmDevice { get; set; }
        public virtual ICollection<AchvLoadctrlMeter> AchvLoadctrlMeter { get; set; }
        public virtual ICollection<AchvPoc> AchvPoc { get; set; }
    }
}
