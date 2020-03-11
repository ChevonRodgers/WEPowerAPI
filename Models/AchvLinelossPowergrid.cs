using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvLinelossPowergrid
    {
        public decimal LineLossId { get; set; }
        public decimal PowerGridId { get; set; }

        public virtual AchvLineloss LineLoss { get; set; }
        public virtual AchvPowergrid PowerGrid { get; set; }
    }
}
