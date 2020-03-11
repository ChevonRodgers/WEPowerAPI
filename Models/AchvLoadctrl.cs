using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvLoadctrl
    {
        public AchvLoadctrl()
        {
            AchvLoadctrlMeter = new HashSet<AchvLoadctrlMeter>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Scheme { get; set; }
        public decimal? Type { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
        public string MonitoredValue { get; set; }
        public decimal? ThresholdNormal { get; set; }
        public decimal? MinOverThresholdDuration { get; set; }
        public decimal? MinUnderThresholdDuration { get; set; }
        public string ActiveTime1 { get; set; }
        public decimal? Duration1 { get; set; }
        public decimal? ThresholdEmergency { get; set; }
        public string MonitoredValue1 { get; set; }
        public decimal? ThresholdNormal1 { get; set; }
        public decimal? ThresholdEmergency1 { get; set; }
        public decimal? MinOverThresholdDuration1 { get; set; }
        public decimal? MinUnderThresholdDuration1 { get; set; }
        public string ActiveTimeRelay11 { get; set; }
        public decimal? DurationRelay11 { get; set; }
        public string RelayEnabled1 { get; set; }
        public decimal? Mode1 { get; set; }
        public decimal? Mode2 { get; set; }
        public string ActionOver1 { get; set; }
        public string ActionOver2 { get; set; }
        public string ActionUnder1 { get; set; }
        public string ActionUnder2 { get; set; }
        public string Scheme1 { get; set; }

        public virtual ICollection<AchvLoadctrlMeter> AchvLoadctrlMeter { get; set; }
    }
}
