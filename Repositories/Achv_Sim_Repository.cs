using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Achv_Sim_Repository: IAchv_Sim_Repository
    {
        SmartLoadManagementContext db;
        public Achv_Sim_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetSupplierID()
        {
            return 0;
        }
        public string GetSimNo()
        {
            return "";
        }
        public string GetSimICCID()
        {
            return "";
        }
        public int GetSimModel()
        {
            return 0;
        }
        public string GetSimIP()
        {
            return "";
        }
        public int GetSimPort()
        {
            return 0;
        }
        public string GetSimAPN()
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
        public int SetSupplierID()
        {
            return 0;
        }
        public string SetSimNo()
        {
            return "";
        }
        public string SetSimICCID()
        {
            return "";
        }
        public int SetSimModel()
        {
            return 0;
        }
        public string SetSimIP()
        {
            return "";
        }
        public int SetSimPort()
        {
            return 0;
        }
        public string SetSimAPN()
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
