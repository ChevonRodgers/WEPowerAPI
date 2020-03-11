using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Achv_LineLoss_Repository: IAchv_LineLoss_Repository
    {
        SmartLoadManagementContext db;
        public Achv_LineLoss_Repository()
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
        public int GetStatus()
        {
            return 0;
        }
        public string GetDesc()
        {
            return "";
        }
        public int GetGatewayMeter_ID()
        {
            return 0;
        }
        public int GetDayCalc()
        {
            return 0;
        }
        public int GetMonthCalc()
        {
            return 0;
        }
        public DateTime GetCalc_Latest()
        {
            return DateTime.Now;
        }
        public int GetCalcTimes()
        {
            return 0;
        }
        public DateTime GetCalc_MonthLatest()
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
        public int SetStatus()
        {
            return 0;
        }
        public string SetDesc()
        {
            return "";
        }
        public int SetGatewayMeter_ID()
        {
            return 0;
        }
        public int SetDayCalc()
        {
            return 0;
        }
        public int SetMonthCalc()
        {
            return 0;
        }
        public DateTime SetCalc_Latest()
        {
            return DateTime.Now;
        }
        public int SetCalcTimes()
        {
            return 0;
        }
        public DateTime SetCalc_MonthLatest()
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
