using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogEmailSms
    {
        public decimal Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string To { get; set; }
        public string Readed { get; set; }
        public decimal Status { get; set; }
        public decimal Type { get; set; }
        public DateTime Crton { get; set; }
    }
}
