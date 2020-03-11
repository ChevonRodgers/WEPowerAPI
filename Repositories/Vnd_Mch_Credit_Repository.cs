using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Vnd_Mch_Credit_Repository: IVnd_Mch_Credit_Repository
    {
        SmartLoadManagementContext db;
        public Vnd_Mch_Credit_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetMCH_ID()
        {
            return 0;
        }
        public double GetAmount()
        {
            return 0.0;
        }
        public string GetRefNo()
        {
            return "";
        }
        public int GetPayMethod()
        {
            return 0;
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
        public int SetMCH_ID()
        {
            return 0;
        }
        public double SetAmount()
        {
            return 0.0;
        }
        public string SetRefNo()
        {
            return "";
        }
        public int SetPayMethod()
        {
            return 0;
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
