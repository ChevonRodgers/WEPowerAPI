using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvOuterRelay
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Protocol { get; set; }
        public decimal ControlType { get; set; }
        public string MonitoredValue { get; set; }
        public decimal? ThresholdNormal { get; set; }
        public decimal? MinOverThresholdDuration { get; set; }
        public decimal? MinUnderThresholdDuration { get; set; }
        public decimal? ThresholdEmergency { get; set; }
        public string ActiveTime { get; set; }
        public decimal? Duration { get; set; }
        public decimal? Mode { get; set; }
        public string ActionOver { get; set; }
        public string ActionUnder { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
    }
}
