using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvLineloss
    {
        public AchvLineloss()
        {
            AchvLinelossPowergrid = new HashSet<AchvLinelossPowergrid>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Status { get; set; }
        public string Descr { get; set; }
        public decimal GatewayMeterId { get; set; }
        public decimal? DayCalc { get; set; }
        public decimal? MonthCalc { get; set; }
        public DateTime? CalcLatest { get; set; }
        public decimal? CalcTimes { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
        public DateTime? CalcMonthLatest { get; set; }

        public virtual ICollection<AchvLinelossPowergrid> AchvLinelossPowergrid { get; set; }
    }
}
