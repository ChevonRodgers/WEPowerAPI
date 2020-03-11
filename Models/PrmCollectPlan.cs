using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmCollectPlan
    {
        public PrmCollectPlan()
        {
            PrmCollectPlanObis = new HashSet<PrmCollectPlanObis>();
        }

        public decimal Id { get; set; }
        public decimal CollectId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal CollectInterval { get; set; }
        public decimal CollectUnit { get; set; }
        public decimal MeteringInterval { get; set; }
        public decimal MetergingUnit { get; set; }
        public decimal Offset { get; set; }
        public decimal OffsetUnit { get; set; }
        public decimal RetryTimes { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual PrmCollect Collect { get; set; }
        public virtual ICollection<PrmCollectPlanObis> PrmCollectPlanObis { get; set; }
    }
}
