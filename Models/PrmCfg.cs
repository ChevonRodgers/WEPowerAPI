﻿using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmCfg
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Status { get; set; }
        public string Descr { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
    }
}
