using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class VndMch
    {
        public VndMch()
        {
            VndMchCredit = new HashSet<VndMchCredit>();
            VndMchUser = new HashSet<VndMchUser>();
        }

        public decimal Id { get; set; }
        public decimal Status { get; set; }
        public string Sn { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Descr { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? VendMinPerTime { get; set; }
        public decimal? VendMaxPerTime { get; set; }
        public decimal? CommissionType { get; set; }
        public decimal? CommissionValue { get; set; }
        public decimal? TotalCharge { get; set; }
        public decimal? TotalSale { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<VndMchCredit> VndMchCredit { get; set; }
        public virtual ICollection<VndMchUser> VndMchUser { get; set; }
    }
}
