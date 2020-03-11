using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvMeterpwd
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Pwdtype { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }
        public string Pwd { get; set; }
    }
}
