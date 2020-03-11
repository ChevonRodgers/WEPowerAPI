using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_Device_Deleted_Repository: IPrm_Device_Deleted_Repository
    {
        SmartLoadManagementContext db;
        public Prm_Device_Deleted_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
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
        public string GetServer()
        {
            return "";
        }
        public int GetPort()
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
        public int SetID()
        {
            return 0;
        }
        public string SetName()
        {
            return "";
        }
        public int SetStatus()
        {
            return 0;
        }
        public string SetServer()
        {
            return "";
        }
        public int SetPort()
        {
            return 0;
        }
        public string SetDescr()
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
