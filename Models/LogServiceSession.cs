using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogServiceSession
    {
        public string SessionId { get; set; }
        public decimal UserId { get; set; }
        public string UserName { get; set; }
        public decimal? CduId { get; set; }
        public decimal Status { get; set; }
        public string Ip { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LatesAction { get; set; }
    }
}
