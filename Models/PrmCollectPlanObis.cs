using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmCollectPlanObis
    {
        public decimal CollectPlanId { get; set; }
        public string Obis { get; set; }
        public decimal OrderNo { get; set; }

        public virtual PrmCollectPlan CollectPlan { get; set; }
    }
}
