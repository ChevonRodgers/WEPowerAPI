using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SmsserverIn
    {
        public long Id { get; set; }
        public int Process { get; set; }
        public string Originator { get; set; }
        public string Type { get; set; }
        public string Encoding { get; set; }
        public DateTime MessageDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string Text { get; set; }
        public string OriginalRefNo { get; set; }
        public DateTime? OriginalReceiveDate { get; set; }
        public string GatewayId { get; set; }
    }
}
