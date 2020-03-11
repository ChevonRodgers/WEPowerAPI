using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_TrfTbl_Repository: IPrm_TrfTbl_Repository
    {
        SmartLoadManagementContext db;
        public Prm_TrfTbl_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetTrfInd_ID()
        {
            return 0;
        }
        public DateTime GetBeginDate()
        {
            return DateTime.Now;
        }
        public string GetScheme()
        {
            return "";
        }
        public int GetStatus()
        {
            return 0;
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
        public int SetTrfInd_ID()
        {
            return 0;
        }
        public DateTime SetBeginDate()
        {
            return DateTime.Now;
        }
        public string SetScheme()
        {
            return "";
        }
        public int SetStatus()
        {
            return 0;
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
