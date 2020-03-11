using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_TmlType_Repository: IPrm_TmlType_Repository
    {
        SmartLoadManagementContext db;
        public Prm_TmlType_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetSupplierId()
        {
            return 0;
        }
        public string GetName()
        {
            return "";
        }
        public string GetDescr()
        {
            return "";
        }
        public int GetCommProtocol()
        {
            return 0;
        }
        public int GetCommType()
        {
            return 0;
        }
        public int GetMeterCommType()
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
        public int SetSupplierId()
        {
            return 0;
        }
        public string SetName()
        {
            return "";
        }
        public string SetDescr()
        {
            return "";
        }
        public int SetCommProtocol()
        {
            return 0;
        }
        public int SetCommType()
        {
            return 0;
        }
        public int SetMeterCommType()
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
