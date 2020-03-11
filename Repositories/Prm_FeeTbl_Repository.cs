using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_FeeTbl_Repository: IPrm_FeeTbl_Repository
    {
        SmartLoadManagementContext db;
        public Prm_FeeTbl_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetFeeInd_ID()
        {
            return 0;
        }
        public int GetFeeType()
        {
            return 0;
        }
        public string GetName()
        {
            return "";
        }
        public double GetValue()
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
        public int SetFeeInd_ID()
        {
            return 0;
        }
        public int SetFeeType()
        {
            return 0;
        }
        public string SetName()
        {
            return "";
        }
        public double SetValue()
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
