using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class OrdTrn
    {
        public OrdTrn()
        {
            OrdTrnDetail = new HashSet<OrdTrnDetail>();
            OrdTrnStep = new HashSet<OrdTrnStep>();
        }

        public decimal Id { get; set; }
        public decimal Ordno { get; set; }
        public decimal MeterId { get; set; }
        public decimal CustomerId { get; set; }
        public decimal PocId { get; set; }
        public decimal MchId { get; set; }
        public decimal TrfTblId { get; set; }
        public decimal IsFree { get; set; }
        public decimal Status { get; set; }
        public decimal Sgc { get; set; }
        public decimal Ti { get; set; }
        public decimal Krn { get; set; }
        public decimal Ken { get; set; }
        public decimal PayAll { get; set; }
        public decimal Change { get; set; }
        public decimal PayMoney { get; set; }
        public decimal EnergyMoney { get; set; }
        public decimal TotalFee { get; set; }
        public decimal? TotalDebt { get; set; }
        public decimal? Energy { get; set; }
        public string Token { get; set; }
        public decimal PayType { get; set; }
        public string Reqid { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<OrdTrnDetail> OrdTrnDetail { get; set; }
        public virtual ICollection<OrdTrnStep> OrdTrnStep { get; set; }
    }
}
