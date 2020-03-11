using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class OrdTrnDebt
    {
        public decimal TrnId { get; set; }
        public decimal DebtId { get; set; }
        public decimal? BalanceBeforeRepay { get; set; }
        public decimal? BalanceAfterRepay { get; set; }
        public decimal? RepayAmount { get; set; }
    }
}
