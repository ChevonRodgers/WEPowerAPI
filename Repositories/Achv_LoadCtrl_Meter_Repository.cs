using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Achv_LoadCtrl_Meter_Repository: IAchv_LoadCtrl_Meter_Repository
    {
        SmartLoadManagementContext db;
        public Achv_LoadCtrl_Meter_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetLoadCtrlID()
        {
            return 0;
        }
        public int GetMeter_ID()
        {
            return 0;
        }
        public int GetRetry_Times()
        {
            return 0;
        }
        public int GetResult()
        {
            return 0;
        }
        public DateTime GetStarTime()
        {
            return DateTime.Now;
        }
        public DateTime GetEndTime()
        {
            return DateTime.Now;
        }
        public DateTime GetCreatedDate()
        {
            return DateTime.Now;
        }
        public int GetCreatedBy()
        {
            return 0;
        }
        public int SetID()
        {
            return 0;
        }
        public int SetLoadCtrlID()
        {
            return 0;
        }
        public int SetMeter_ID()
        {
            return 0;
        }
        public int SetRetry_Times()
        {
            return 0;
        }
        public int SetResult()
        {
            return 0;
        }
        public DateTime SetStarTime()
        {
            return DateTime.Now;
        }
        public DateTime SetEndTime()
        {
            return DateTime.Now;
        }
        public DateTime SetCreatedDate()
        {
            return DateTime.Now;
        }
        public int SetCreatedBy()
        {
            return 0;
        }
    }
}
