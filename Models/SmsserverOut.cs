using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SmsserverOut
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Recipient { get; set; }
        public string Text { get; set; }
        public string WapUrl { get; set; }
        public DateTime? WapExpiryDate { get; set; }
        public string WapSignal { get; set; }
        public DateTime CreateDate { get; set; }
        public string Originator { get; set; }
        public string Encoding { get; set; }
        public int StatusReport { get; set; }
        public int FlashSms { get; set; }
        public int SrcPort { get; set; }
        public int DstPort { get; set; }
        public DateTime? SentDate { get; set; }
        public string RefNo { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public int Errors { get; set; }
        public string GatewayId { get; set; }
    }
}
