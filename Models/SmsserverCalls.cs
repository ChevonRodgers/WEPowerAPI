using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SmsserverCalls
    {
        public long Id { get; set; }
        public DateTime CallDate { get; set; }
        public string GatewayId { get; set; }
        public string CallerId { get; set; }
    }
}
