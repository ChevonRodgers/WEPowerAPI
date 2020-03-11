using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmPowergridtype
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string SubId { get; set; }
        public string Ico { get; set; }
        public decimal? IsVoltage { get; set; }
        public decimal? IsGps { get; set; }
        public decimal? IsEnd { get; set; }
    }
}
