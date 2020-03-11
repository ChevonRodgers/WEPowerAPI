using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Achv_Tml_Repository: IAchv_Tml_Repository
    {
        SmartLoadManagementContext db;
        public Achv_Tml_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public string GetSN()
        {
            return "";
        }
        public int GetStatus()
        {
            return 0;
        }
        public string GetIMEI()
        {
            return "";
        }
        public int GetTmlTypeID()
        {
            return 0;
        }
        public string GetAssetNo()
        {
            return "";
        }
        public int GetPowerGridID()
        {
            return 0;
        }
        public int GetPrm_Collect_ID()
        {
            return 0;
        }
        public int GetPrm_Device_ID()
        {
            return 0;
        }
        public int GetSimID()
        {
            return 0;
        }
        public int GetPrm_Cfg_ID()
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
        public string SetSN()
        {
            return "";
        }
        public int SetStatus()
        {
            return 0;
        }
        public string SetIMEI()
        {
            return "";
        }
        public int SetTmlTypeID()
        {
            return 0;
        }
        public string SetAssetNo()
        {
            return "";
        }
        public int SetPowerGridID()
        {
            return 0;
        }
        public int SetPrm_Collect_ID()
        {
            return 0;
        }
        public int SetPrm_Device_ID()
        {
            return 0;
        }
        public int SetSimID()
        {
            return 0;
        }
        public int SetPrm_Cfg_ID()
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
