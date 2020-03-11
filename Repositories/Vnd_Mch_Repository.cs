using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Vnd_Mch_Repository: IVnd_Mch_Repository
    {
        SmartLoadManagementContext db;
        public Vnd_Mch_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetStatus()
        {
            return 0;
        }
        public string GetSN()
        {
            return "";
        }
        public string GetName()
        {
            return "";
        }
        public string GetContactPerson()
        {
            return "";
        }
        public string GetTel()
        {
            return "";
        }
        public string GetEmail()
        {
            return "";
        }
        public string GetAddress()
        {
            return "";
        }
        public string GetDescr()
        {
            return "";
        }
        public DateTime GetStartTime()
        {
            return DateTime.Now;
        }
        public DateTime GetEndTime()
        {
            return DateTime.Now;
        }
        public double GetCreditAmount()
        {
            return 0.0;
        }
        public double GetCreditLimit()
        {
            return 0.0;
        }
        public double GetVendMinPerTime()
        {
            return 0.0;
        }
        public double GetVendMaxPerTime()
        {
            return 0.0;
        }
        public int GetCommissionType()
        {
            return 0;
        }
        public double GetCommissionValue()
        {
            return 0.0;
        }
        public double GetTotalCharge()
        {
            return 0.0;
        }
        public double GetTotalSale()
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
        public int SetID()
        {
            return 0;
        }
        public int SetStatus()
        {
            return 0;
        }
        public string SetSN()
        {
            return "";
        }
        public string SetName()
        {
            return "";
        }
        public string SetContactPerson()
        {
            return "";
        }
        public string SetTel()
        {
            return "";
        }
        public string SetEmail()
        {
            return "";
        }
        public string SetAddress()
        {
            return "";
        }
        public string SetDescr()
        {
            return "";
        }
        public DateTime SetStartTime()
        {
            return DateTime.Now;
        }
        public DateTime SetEndTime()
        {
            return DateTime.Now;
        }
        public double SetCreditAmount()
        {
            return 0.0;
        }
        public double SetCreditLimit()
        {
            return 0.0;
        }
        public double SetVendMinPerTime()
        {
            return 0.0;
        }
        public double SetVendMaxPerTime()
        {
            return 0.0;
        }
        public int SetCommissionType()
        {
            return 0;
        }
        public double SetCommissionValue()
        {
            return 0.0;
        }
        public double SetTotalCharge()
        {
            return 0.0;
        }
        public double SetTotalSale()
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
    }
}
