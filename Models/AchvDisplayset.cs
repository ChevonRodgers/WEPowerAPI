﻿using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvDisplayset
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string DisplayType { get; set; }
        public decimal AutoScroll { get; set; }
        public decimal Backlight { get; set; }
        public string Obis { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
        public decimal? Protocol { get; set; }
    }
}
