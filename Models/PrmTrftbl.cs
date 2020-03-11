using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmTrftbl
    {
        public decimal Id { get; set; }
        public decimal TrfIndId { get; set; }
        public DateTime BeginDate { get; set; }
        public string Scheme { get; set; }
        public decimal Status { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual PrmTrfind TrfInd { get; set; }
    }
}
