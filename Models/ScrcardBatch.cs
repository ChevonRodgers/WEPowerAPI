using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class ScrcardBatch
    {
        public ScrcardBatch()
        {
            ScrcardCard = new HashSet<ScrcardCard>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal Sn { get; set; }
        public string PrivateKey { get; set; }
        public decimal CardAmount { get; set; }
        public decimal CardQuantity { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime Deadline { get; set; }
        public decimal Status { get; set; }
        public string Descr { get; set; }
        public DateTime Crton { get; set; }
        public decimal Crtby { get; set; }
        public DateTime Mdfon { get; set; }
        public decimal Mdfby { get; set; }

        public virtual ICollection<ScrcardCard> ScrcardCard { get; set; }
    }
}
