using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Achv_Meter_Repository: IAchv_Meter_Repository
    {
        SmartLoadManagementContext db;
        public Achv_Meter_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public string GetMSNO()
        {
            return "";
        }
        public int GetStatus()
        {
            return 0;
        }
        public int GetMeterTypeID()
        {
            return 0;
        }
        public int GetPrmCollectID()
        {
            return 0;
        }
        public int GetPrmDeviceID()
        {
            return 0;
        }
        public int GetSimID()
        {
            return 0;
        }
        public string GetAssetNo()
        {
            return "";
        }
        public string GetDescr()
        {
            return "";
        }
        public int GetKRN()
        {
            return 0;
        }
        public int GetTI()
        {
            return 0;
        }
        public int GetKEN()
        {
            return 0;
        }
        public int GetSGC()
        {
            return 0;
        }
        public DateTime GetLastVending()
        {
            return DateTime.Now;
        }
        public DateTime GetLastFreeVending()
        {
            return DateTime.Now;
        }
        public double GetCurrentMonthUnits()
        {
            return 0.0;
        }
        public double GetCurrentMonthMoney()
        {
            return 0.0;
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
        public int GetDLMSAuthentication()
        {
            return 0;
        }
        public string GetDLMSPassword()
        {
            return "";
        }
        public int GetDLMSAESGCM128()
        {
            return 0;
        }
        public string GetDLMSAK()
        {
            return "";
        }
        public string GetDLMSEK()
        {
            return "";
        }
        public int GetIsRegister()
        {
            return 0;
        }
        public int GetPrm_CFG_ID()
        {
            return 0;
        }

        public int SetID()
        {
            return 0;
        }
        public string SetMSNO()
        {
            return "";
        }
        public int SetStatus()
        {
            return 0;
        }
        public int SetMeterTypeID()
        {
            return 0;
        }
        public int SetPrmCollectID()
        {
            return 0;
        }
        public int SetPrmDeviceID()
        {
            return 0;
        }
        public int SetSimID()
        {
            return 0;
        }
        public string SetAssetNo()
        {
            return "";
        }
        public string SetDescr()
        {
            return "";
        }
        public int SetKRN()
        {
            return 0;
        }
        public int SetTI()
        {
            return 0;
        }
        public int SetKEN()
        {
            return 0;
        }
        public int SetSGC()
        {
            return 0;
        }
        public DateTime SetLastVending()
        {
            return DateTime.Now;
        }
        public DateTime SetLastFreeVending()
        {
            return DateTime.Now;
        }
        public double SetCurrentMonthUnits()
        {
            return 0.0;
        }
        public double SetCurrentMonthMoney()
        {
            return 0.0;
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
        public int SetDLMSAuthentication()
        {
            return 0;
        }
        public string SetDLMSPassword()
        {
            return "";
        }
        public int SetDLMSAESGCM128()
        {
            return 0;
        }
        public string SetDLMSAK()
        {
            return "";
        }
        public string SetDLMSEK()
        {
            return "";
        }
        public int SetIsRegister()
        {
            return 0;
        }
        public int SetPrm_CFG_ID()
        {
            return 0;
        }
    }
}
