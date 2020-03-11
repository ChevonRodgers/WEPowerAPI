using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class DataCPostpaidBilling
    {
        public DateTime DataTime { get; set; }
        public decimal MeterId { get; set; }
        public decimal BillingValue { get; set; }
        public decimal BillingState { get; set; }
        public DateTime SaveTime { get; set; }
    }
}
