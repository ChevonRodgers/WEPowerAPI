using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmEvtDef
    {
        public decimal TmlProtocolId { get; set; }
        public decimal EvtId { get; set; }
        public decimal Class2Id { get; set; }
        public decimal Class1Id { get; set; }
        public string EvtDesc { get; set; }
        public decimal? IfUrgentNotice { get; set; }
    }
}
