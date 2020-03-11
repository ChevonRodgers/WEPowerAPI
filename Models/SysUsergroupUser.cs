using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysUsergroupUser
    {
        public decimal UserGroupId { get; set; }
        public decimal UserId { get; set; }

        public virtual SysUser User { get; set; }
        public virtual SysUsergroup UserGroup { get; set; }
    }
}
