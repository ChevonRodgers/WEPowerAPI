using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataCMaxdemand
    {
        public DateTime DataTime { get; set; }
        public decimal MeterId { get; set; }
        public decimal TariffId { get; set; }
        public DateTime? SavedbTime { get; set; }
        public decimal? KwDemandImport { get; set; }
        public DateTime? KwDemandImportTime { get; set; }
        public decimal? KwDemandExport { get; set; }
        public DateTime? KwDemandExportTime { get; set; }
        public decimal? KvarDemandImport { get; set; }
        public DateTime? KvarDemandImportTime { get; set; }
        public decimal? KvarDemandExport { get; set; }
        public DateTime? KvarDemandExportTime { get; set; }
        public string StatusWord { get; set; }
    }
}
