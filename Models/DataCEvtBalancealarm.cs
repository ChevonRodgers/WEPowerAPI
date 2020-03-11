using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataCEvtBalancealarm
    {
        public int Id { get; set; }
        public decimal MeterId { get; set; }
        public DateTime EvtTime { get; set; }
        public decimal EvtId { get; set; }
        public DateTime? SavedbTime { get; set; }
        public decimal? Currentblance { get; set; }
        public decimal? IsNoticed { get; set; }
    }
}
