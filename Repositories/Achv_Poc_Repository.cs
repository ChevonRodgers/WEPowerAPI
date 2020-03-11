using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Achv_Poc_Repository: IAchv_Poc_Repository
    {
        SmartLoadManagementContext db;
        public Achv_Poc_Repository()
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
        public int GetMeterID()
        {
            return 0;
        }
        public int GetPowerGridID()
        {
            return 0;
        }
        public int GetCustomerID()
        {
            return 0;
        }
        public string GetAddress()
        {
            return "";
        }
        public int GetTrfIndID()
        {
            return 0;
        }
        public int GetSGID()
        {
            return 0;
        }
        public string GetCT()
        {
            return "";
        }
        public string GetPT()
        {
            return "";
        }
        public int GetCTPRatio()
        {
            return 0;
        }
        public int GetCapacity()
        {
            return 0;
        }
        public int GetVoltageGrade()
        {
            return 0;
        }
        public string GetLng()
        {
            return "";
        }
        public string GetLat()
        {
            return "";
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
        public string SetSN()
        {
            return "";
        }
        public int SetStatus()
        {
            return 0;
        }
        public int SetMeterID()
        {
            return 0;
        }
        public int SetPowerGridID()
        {
            return 0;
        }
        public int SetCustomerID()
        {
            return 0;
        }
        public string SetAddress()
        {
            return "";
        }
        public int SetTrfIndID()
        {
            return 0;
        }
        public int SetSGID()
        {
            return 0;
        }
        public string SetCT()
        {
            return "";
        }
        public string SetPT()
        {
            return "";
        }
        public int SetCTPRatio()
        {
            return 0;
        }
        public int SetCapacity()
        {
            return 0;
        }
        public int SetVoltageGrade()
        {
            return 0;
        }
        public string SetLng()
        {
            return "";
        }
        public string SetLat()
        {
            return "";
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
