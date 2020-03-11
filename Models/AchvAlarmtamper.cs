using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvAlarmtamper
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Datatype { get; set; }
        public string Datavalue { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
        public decimal? Protocol { get; set; }
    }
}
