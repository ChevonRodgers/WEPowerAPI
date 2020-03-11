using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvBasicset
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Energydigit { get; set; }
        public string Demanddigit { get; set; }
        public string Commspeed { get; set; }
        public string Demandperiod { get; set; }
        public string Demandnumberperiods { get; set; }
        public string Modulereset { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
    }
}
