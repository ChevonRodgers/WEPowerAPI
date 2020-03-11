using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Achv_PowerGrid_Repository: IAchv_PowerGrid_Repository
    {
        SmartLoadManagementContext db;
        public Achv_PowerGrid_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        { 
            return 0;
        }
        public int GetPID()
        {
            return 0;
        }
        public int GetPowerGridType()
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
        public int GetVoltageGrade()
        {
            return 0;
        }
        public int GetStatus()
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
        public int SetPID()
        {
            return 0;
        }
        public int SetPowerGridType()
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
        public int SetVoltageGrade()
        {
            return 0;
        }
        public int SetStatus()
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
