using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysRolePage
    {
        public decimal RoleId { get; set; }
        public decimal PageId { get; set; }

        public virtual SysPage Page { get; set; }
        public virtual SysRole Role { get; set; }
    }
}
