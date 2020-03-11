using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class OrdManage
    {
        public decimal Id { get; set; }
        public decimal? TrnId { get; set; }
        public decimal MeterId { get; set; }
        public decimal PocId { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal? TokenType { get; set; }
        public decimal? Val { get; set; }
        public decimal? Sgc { get; set; }
        public decimal? Ti { get; set; }
        public decimal? Krn { get; set; }
        public decimal? Ken { get; set; }
        public string Token1 { get; set; }
        public string Token2 { get; set; }
        public decimal? SgcNew { get; set; }
        public decimal? TiNew { get; set; }
        public decimal? KrnNew { get; set; }
        public decimal? KenNew { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public string Remark { get; set; }
    }
}
