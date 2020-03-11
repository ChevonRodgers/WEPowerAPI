using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysUsergroupObj
    {
        public decimal UserGroupId { get; set; }
        public decimal ObjId { get; set; }

        public virtual AchvPowergrid Obj { get; set; }
        public virtual SysUsergroup UserGroup { get; set; }
    }
}
