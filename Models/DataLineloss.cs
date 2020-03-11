using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataLineloss
    {
        public decimal LineLossId { get; set; }
        public DateTime Date { get; set; }
        public decimal Type { get; set; }
        public DateTime? SavedbTime { get; set; }
        public decimal? GatewayMeterId { get; set; }
        public decimal? GatewayMeterKWh { get; set; }
        public decimal? GatewayMeterKWhStart { get; set; }
        public decimal? GatewayMeterKWhEnd { get; set; }
        public decimal? MetersSumKWh { get; set; }
        public decimal? MetersSumNumber { get; set; }
        public decimal? MetersTotalNumber { get; set; }
    }
}
