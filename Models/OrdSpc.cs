using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class OrdSpc
    {
        public decimal Id { get; set; }
        public decimal MeterId { get; set; }
        public decimal CustomerId { get; set; }
        public decimal PocId { get; set; }
        public decimal MchId { get; set; }
        public decimal Status { get; set; }
        public decimal Sgc { get; set; }
        public decimal Ti { get; set; }
        public decimal Krn { get; set; }
        public decimal Ken { get; set; }
        public decimal? Money { get; set; }
        public decimal? Energy { get; set; }
        public string Token { get; set; }
        public decimal PayType { get; set; }
        public string TransferMsno { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
    }
}
