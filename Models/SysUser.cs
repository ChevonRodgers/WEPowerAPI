using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class SysUser
    {
        public SysUser()
        {
            LogLogin = new HashSet<LogLogin>();
            LogMsg = new HashSet<LogMsg>();
            LogOperating = new HashSet<LogOperating>();
            LogPassword = new HashSet<LogPassword>();
            SysNoticeUser = new HashSet<SysNoticeUser>();
            SysUsergroupUser = new HashSet<SysUsergroupUser>();
            VndMchUser = new HashSet<VndMchUser>();
        }

        public decimal Id { get; set; }
        public decimal? RoleId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public decimal Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Gender { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? LatestMdfpwd { get; set; }
        public DateTime? LatestLogin { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual SysRole Role { get; set; }
        public virtual SysUserSubscribe SysUserSubscribe { get; set; }
        public virtual ICollection<LogLogin> LogLogin { get; set; }
        public virtual ICollection<LogMsg> LogMsg { get; set; }
        public virtual ICollection<LogOperating> LogOperating { get; set; }
        public virtual ICollection<LogPassword> LogPassword { get; set; }
        public virtual ICollection<SysNoticeUser> SysNoticeUser { get; set; }
        public virtual ICollection<SysUsergroupUser> SysUsergroupUser { get; set; }
        public virtual ICollection<VndMchUser> VndMchUser { get; set; }
    }
}
