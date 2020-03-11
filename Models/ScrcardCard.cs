using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class ScrcardCard
    {
        public decimal Id { get; set; }
        public decimal BatchId { get; set; }
        public decimal CardNo { get; set; }
        public decimal RandNo { get; set; }
        public decimal? Status { get; set; }
        public decimal? Ordno { get; set; }
        public DateTime? ActiveOn { get; set; }
        public decimal? ActiveByPhone { get; set; }
        public decimal? ActivePassword { get; set; }

        public virtual ScrcardBatch Batch { get; set; }
    }
}
