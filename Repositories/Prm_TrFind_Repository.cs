using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_TrFind_Repository: IPrm_TrFind_Repository
    {
        SmartLoadManagementContext db;
        public Prm_TrFind_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        { 
            return 0;
        }
        public int GetfeeIng_ID()
        {
            return 0;
        }
        public int GetTI()
        {
            return 0;
        }
        public int Get_Type()
        {
            return 0;
        }
        public string GetName()
        {
            return "";
        }
        public string GetDescr()
        {
            return "";
        }
        public int GetStatus()
        {
            return 0;
        }
        public string GetFriendlyTime()
        {
            return "";
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
        public int SetfeeIng_ID()
        {
            return 0;
        }
        public int SetTI()
        {
            return 0;
        }
        public int Set_Type()
        {
            return 0;
        }
        public string SetName()
        {
            return "";
        }
        public string SetDescr()
        {
            return "";
        }
        public int SetStatus()
        {
            return 0;
        }
        public string SetFriendlyTime()
        {
            return "";
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
