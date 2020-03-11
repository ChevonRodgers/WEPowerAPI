using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataCOnline
    {
        public decimal MtTmlId { get; set; }
        public decimal MtTmlType { get; set; }
        public DateTime OccurTime { get; set; }
        public decimal IsOnline { get; set; }
        public string Ip { get; set; }
    }
}
