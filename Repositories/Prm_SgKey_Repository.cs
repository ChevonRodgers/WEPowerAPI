using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_SgKey_Repository: IPrm_SgKey_Repository
    {
        SmartLoadManagementContext db;
        public Prm_SgKey_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetSG_ID()
        {
            return 0;
        }
        public int GetKRN()
        {
            return 0;
        }
        public int GetKEN()
        {
            return 0;
        }
        public DateTime GetDeadLine()
        {
            return DateTime.Now;
        }
        public DateTime GetBaseLine()
        {
            return DateTime.Now;
        }
        public DateTime GetCreatedDate()
        {
            return DateTime.Now;
        }
        public int GetCreatedBy()
        {
            return 0;
        }
        public DateTime GetModifiedDate()
        {
            return DateTime.Now;
        }
        public int GetModifiedBy()
        {
            return 0;
        }
        public int SetID()
        {
            return 0;
        }
        public int SetSG_ID()
        {
            return 0;
        }
        public int SetKRN()
        {
            return 0;
        }
        public int SetKEN()
        {
            return 0;
        }
        public DateTime SetDeadLine()
        {
            return DateTime.Now;
        }
        public DateTime SetBaseLine()
        {
            return DateTime.Now;
        }
        public DateTime SetCreatedDate()
        {
            return DateTime.Now;
        }
        public int SetCreatedBy()
        {
            return 0;
        }
        public DateTime SetModifiedDate()
        {
            return DateTime.Now;
        }
        public int SetModifiedBy()
        {
            return 0;
        }
    }
}
