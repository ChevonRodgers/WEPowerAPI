using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysBase
    {
        public string Tag { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public decimal? OrderNo { get; set; }
        public decimal? AllowMdf { get; set; }
        public string Vld { get; set; }
        public decimal? IsShow { get; set; }
    }
}
