using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmFeetblGhana
    {
        public decimal Id { get; set; }
        public decimal FeeIndId { get; set; }
        public decimal? KWh { get; set; }
        public decimal? Price { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Nhil { get; set; }
        public decimal? Subside1 { get; set; }
        public decimal? Subside2 { get; set; }
        public decimal? ServiceCharge { get; set; }
        public decimal? Relief { get; set; }
        public decimal? StreetLight { get; set; }
        public decimal? GovLevy { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
    }
}
