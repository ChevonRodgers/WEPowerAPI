using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvDebt
    {
        public decimal Id { get; set; }
        public decimal CustomerId { get; set; }
        public string Name { get; set; }
        public string ContractNo { get; set; }
        public decimal Status { get; set; }
        public decimal DebtType { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public decimal RepayType { get; set; }
        public decimal? DebtAmountPct { get; set; }
        public decimal? PurchaseAmountPct { get; set; }
        public decimal? MinAmount { get; set; }
        public DateTime? RepayLatest { get; set; }
        public decimal? RepayTimes { get; set; }
        public string Descr { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
    }
}
