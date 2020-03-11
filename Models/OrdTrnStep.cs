using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class OrdTrnStep
    {
        public decimal TrnId { get; set; }
        public decimal TrfTblId { get; set; }
        public decimal? Step { get; set; }
        public decimal? Value { get; set; }
        public decimal? KWh { get; set; }
        public decimal? Cost { get; set; }

        public virtual OrdTrn Trn { get; set; }
    }
}
