using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataCEvt
    {
        public DateTime EvtTime { get; set; }
        public decimal MtTmlId { get; set; }
        public decimal MtTmlType { get; set; }
        public decimal TmlProtocolId { get; set; }
        public decimal Class1Id { get; set; }
        public decimal Class2Id { get; set; }
        public decimal EvtId { get; set; }
        public DateTime? SavedbTime { get; set; }
        public string Descr { get; set; }
        public string Statusword { get; set; }
    }
}
