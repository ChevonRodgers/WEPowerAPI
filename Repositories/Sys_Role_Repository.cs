using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Sys_Role_Repository: ISys_Role_Repository
    {
        SmartLoadManagementContext db;
        public Sys_Role_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GETID()
        {
            return 0;
        }
        public string GetName()
        {
            return "";
        }
        public int GetStatus()
        {
            return 0;
        }
        public string GetDescr()
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
        public int SETID()
        {
            return 0;
        }
        public string SETName()
        {
            return "";
        }
        public int SETStatus()
        {
            return 0;
        }
        public string SETDescr()
        {
            return "";
        }
        public DateTime SETCreatedDate()
        {
            return DateTime.Now;
        }
        public int SETCreatedBy()
        {
            return 0;
        }
        public DateTime SETModifiedDate()
        {
            return DateTime.Now;
        }
        public int SETModifiedBy()
        {
            return 0;
        }
    }
}
