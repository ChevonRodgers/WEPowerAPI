using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class AchvCustomer
    {
        public AchvCustomer()
        {
            AchvPoc = new HashSet<AchvPoc>();
        }

        public decimal Id { get; set; }
        public string UserName { get; set; }
        public string AccountNo { get; set; }
        public string IdentityId { get; set; }
        public string PassWord { get; set; }
        public decimal CustomerType { get; set; }
        public decimal Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Sex { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal? Postcode { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<AchvPoc> AchvPoc { get; set; }
    }
}
