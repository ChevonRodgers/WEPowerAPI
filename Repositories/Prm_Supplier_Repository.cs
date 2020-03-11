using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_Supplier_Repository: IPrm_Supplier_Repository
    {
        SmartLoadManagementContext db;
        public Prm_Supplier_Repository()
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
        public string GetHttp()
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
        public string GetBizContactPerson()
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
        public string SetHttp()
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
        public string SetBizContactPerson()
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
