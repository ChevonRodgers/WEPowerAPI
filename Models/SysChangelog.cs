using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysChangelog
    {
        public string Version { get; set; }
        public DateTime Datetime { get; set; }
        public string Descr { get; set; }
    }
}
