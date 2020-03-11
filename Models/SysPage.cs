using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysPage
    {
        public SysPage()
        {
            SysRolePage = new HashSet<SysRolePage>();
        }

        public decimal Id { get; set; }
        public decimal? ParentId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public decimal? OrderNo { get; set; }
        public string Ico { get; set; }

        public virtual ICollection<SysRolePage> SysRolePage { get; set; }
    }
}
