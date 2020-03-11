using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataCLoad
    {
        public DateTime DataTime { get; set; }
        public decimal MeterId { get; set; }
        public DateTime? SavedbTime { get; set; }
        public decimal? KwImport { get; set; }
        public decimal? KwExport { get; set; }
        public decimal? KvarImport { get; set; }
        public decimal? KvarExport { get; set; }
        public decimal? KvaImport { get; set; }
        public decimal? KvaExport { get; set; }
        public decimal? Frequence { get; set; }
        public decimal? PfTotal { get; set; }
        public decimal? PfA { get; set; }
        public decimal? PfB { get; set; }
        public decimal? PfC { get; set; }
        public decimal? VolA { get; set; }
        public decimal? VolB { get; set; }
        public decimal? VolC { get; set; }
        public decimal? CurrentA { get; set; }
        public decimal? CurrentB { get; set; }
        public decimal? CurrentC { get; set; }
        public decimal? Current0 { get; set; }
        public decimal? KwA { get; set; }
        public decimal? KwB { get; set; }
        public decimal? KwC { get; set; }
        public decimal? KvarA { get; set; }
        public decimal? KvarB { get; set; }
        public decimal? KvarC { get; set; }
        public decimal? KvaA { get; set; }
        public decimal? KvaB { get; set; }
        public decimal? KvaC { get; set; }
        public decimal? KwAExport { get; set; }
        public decimal? KwBExport { get; set; }
        public decimal? KwCExport { get; set; }
        public decimal? KvarAExport { get; set; }
        public decimal? KvarBExport { get; set; }
        public decimal? KvarCExport { get; set; }
        public decimal? KvaAExport { get; set; }
        public decimal? KvaBExport { get; set; }
        public decimal? KvaCExport { get; set; }
        public decimal? KwDemandAvgImport { get; set; }
        public decimal? KwDemandAvgExport { get; set; }
        public decimal? KvarDemandAvgImport { get; set; }
        public decimal? KvarDemandAvgExport { get; set; }
        public decimal? VolAvgA { get; set; }
        public decimal? VolAvgB { get; set; }
        public decimal? VolAvgC { get; set; }
        public decimal? CurrentAvgA { get; set; }
        public decimal? CurrentAvgB { get; set; }
        public decimal? CurrentAvgC { get; set; }
        public string StatusWord { get; set; }
        public decimal? SignalStrength { get; set; }
        public decimal? AngleUiA { get; set; }
        public decimal? AngleUiB { get; set; }
        public decimal? AngleUiC { get; set; }
    }
}
