using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_Collect_Plan_Repository: IPrm_Collect_Plan_Repository
    {
        SmartLoadManagementContext db;
        public Prm_Collect_Plan_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetCollectID()
        {
            return 0;
        }
        public string GetName()
        {
            return "";
        }
        public string Get_Type()
        {
            return "";
        }
        public int GetCollectInterval()
        {
            return 0;
        }
        public int GetCollectUnit()
        {
            return 0;
        }
        public int GetMeteringInterval()
        {
            return 0;
        }
        public int GetMetergingUnit()
        {
            return 0;
        }
        public int GetOffset()
        {
            return 0;
        }
        public int GetOffsetUnit()
        {
            return 0;
        }
        public int GetRetryTimes()
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
        public int SetCollectID()
        {
            return 0;
        }
        public string SetName()
        {
            return "";
        }
        public string SetType()
        {
            return "";
        }
        public int SetCollectInterval()
        {
            return 0;
        }
        public int SetCollectUnit()
        {
            return 0;
        }
        public int SetMeteringInterval()
        {
            return 0;
        }
        public int SetMetergingUnit()
        {
            return 0;
        }
        public int SetOffset()
        {
            return 0;
        }
        public int SetOffsetUnit()
        {
            return 0;
        }
        public int SetRetryTimes()
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
