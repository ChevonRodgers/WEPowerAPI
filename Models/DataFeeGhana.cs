using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataFeeGhana
    {
        public decimal Id { get; set; }
        public decimal MeterId { get; set; }
        public decimal CustomerId { get; set; }
        public decimal PocId { get; set; }
        public decimal FeeindGhanaId { get; set; }
        public decimal FeetblGhanaId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Crton { get; set; }
        public decimal Status { get; set; }
        public decimal? KWh { get; set; }
        public decimal? UnitsCharge { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Nhil { get; set; }
        public decimal? Subside1 { get; set; }
        public decimal? Subside2 { get; set; }
        public decimal? ServiceCharge { get; set; }
        public decimal? Relief { get; set; }
        public decimal? StreetLight { get; set; }
        public decimal? GovLevy { get; set; }
    }
}
