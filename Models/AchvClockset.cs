using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvClockset
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Datetime { get; set; }
        public string Timezone { get; set; }
        public string Daylightenabled { get; set; }
        public string Daylightdeviation { get; set; }
        public string Daylightbegin { get; set; }
        public string Daylightend { get; set; }
        public DateTime? Crton { get; set; }
        public decimal? Crtby { get; set; }
        public DateTime? Mdfon { get; set; }
        public decimal? Mdfby { get; set; }
    }
}
