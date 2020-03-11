using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataMtKwhDay
    {
        public DateTime Date { get; set; }
        public decimal MeterId { get; set; }
        public decimal TariffId { get; set; }
        public DateTime? SavedbTime { get; set; }
        public DateTime? Begintime { get; set; }
        public DateTime? Endtime { get; set; }
        public decimal? KwhImport { get; set; }
        public decimal? KwhImportStart { get; set; }
        public decimal? KwhImportEnd { get; set; }
        public decimal? KwhExport { get; set; }
        public decimal? KwhExportStart { get; set; }
        public decimal? KwhExportEnd { get; set; }
        public decimal? KvarhImport { get; set; }
        public decimal? KvarhImportStart { get; set; }
        public decimal? KvarhImportEnd { get; set; }
        public decimal? KvarhExport { get; set; }
        public decimal? KvarhExportStart { get; set; }
        public decimal? KvarhExportEnd { get; set; }
        public decimal? KvahImport { get; set; }
        public decimal? KvahImportStart { get; set; }
        public decimal? KvahImportEnd { get; set; }
        public decimal? KvahExport { get; set; }
        public decimal? KvahExportStart { get; set; }
        public decimal? KvahExportEnd { get; set; }
        public decimal? KwhAbs { get; set; }
        public decimal? KwhAbsStart { get; set; }
        public decimal? KwhAbsEnd { get; set; }
        public decimal? KvarhAbs { get; set; }
        public decimal? KvarhAbsStart { get; set; }
        public decimal? KvarhAbsEnd { get; set; }
    }
}
