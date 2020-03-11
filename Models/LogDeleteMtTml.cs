using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogDeleteMtTml
    {
        public decimal MtTmlId { get; set; }
        public decimal MtTmlType { get; set; }
        public string Msno { get; set; }
        public decimal CommType { get; set; }
        public DateTime Crton { get; set; }
    }
}
