using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataCElecMonthfrozen
    {
        public DateTime DataTime { get; set; }
        public decimal MeterId { get; set; }
        public decimal TariffId { get; set; }
        public DateTime? SavedbTime { get; set; }
        public decimal? KwhImport { get; set; }
        public decimal? KwhExport { get; set; }
        public decimal? KvarhImport { get; set; }
        public decimal? KvarhExport { get; set; }
        public decimal? KvahImport { get; set; }
        public decimal? KvahExport { get; set; }
        public decimal? KwhAbs { get; set; }
        public decimal? KvarhAbs { get; set; }
        public decimal? Currentblance { get; set; }
        public decimal? ConsumptionCredit { get; set; }
        public decimal? ConsumptionEnergy { get; set; }
        public decimal? KwDemandCumulativeImport { get; set; }
        public decimal? KwDemandCumulativeExport { get; set; }
        public decimal? KvarDemandCumulativeImport { get; set; }
        public decimal? KvarDemandCumulativeExport { get; set; }
        public decimal? TimesBilling { get; set; }
        public decimal? KvarhQi { get; set; }
        public decimal? KvarhQii { get; set; }
        public decimal? KvarhQiii { get; set; }
        public decimal? KvarhQiv { get; set; }
    }
}
