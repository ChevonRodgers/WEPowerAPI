using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvPoc
    {
        public decimal Id { get; set; }
        public string Sn { get; set; }
        public decimal Status { get; set; }
        public decimal? MeterId { get; set; }
        public decimal? PowerGridId { get; set; }
        public decimal? CustomerId { get; set; }
        public string Address { get; set; }
        public decimal? TrfIndId { get; set; }
        public decimal? SgId { get; set; }
        public string Ct { get; set; }
        public string Pt { get; set; }
        public decimal? Ctptratio { get; set; }
        public decimal? Capacity { get; set; }
        public decimal? VoltageGrade { get; set; }
        public string Lng { get; set; }
        public string Lat { get; set; }
        public string Descr { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual AchvCustomer Customer { get; set; }
        public virtual AchvMeter Meter { get; set; }
        public virtual AchvPowergrid PowerGrid { get; set; }
        public virtual PrmSg Sg { get; set; }
        public virtual PrmTrfind TrfInd { get; set; }
    }
}
