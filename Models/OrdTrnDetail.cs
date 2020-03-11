using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class OrdTrnDetail
    {
        public decimal? TrnId { get; set; }
        public decimal? FeeTblId { get; set; }
        public decimal? FeeType { get; set; }
        public string Name { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? Value { get; set; }

        public virtual OrdTrn Trn { get; set; }
    }
}
