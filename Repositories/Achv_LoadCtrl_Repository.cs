using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Achv_LoadCtrl_Repository : IAchv_LoadCtrl_Repository
    {
        SmartLoadManagementContext db;
        public Achv_LoadCtrl_Repository()
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
        public int Get_Type()
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
        public string GetMonitoredValue()
        {
            return "";
        }

        public double GetThresholdNormal()
        {
            return 0.0;
        }
        public int GetMinOverThresholdDuration()
        {
            return 0;
        }
        public int GetMinUnderThresholdDuration()
        {
            return 0;
        }
        public string GetActiveTime()
        {
            return "";
        }
        public int GetDuration()
        {
            return 0;
        }
        public double GetMonitoredValue1()
        {
            return 0.0;
        }
        public double GetThresholdNormal1()
        {
            return 0.0;
        }
        public double GetThresholdEmergency1()
        {
            return 0.0;
        }
        public int GetMinOverThresholdDuration1()
        {
            return 0;
        }
        public int GetMinUnderThresholdDuration1()
        {
            return 0;
        }
        public string GetActiveTimeRelay1_1()
        {
            return "";
        }

        public int GetDurationDelay1_1()
        {
            return 0;
        }
        public bool GetRelayEnabled1()
        {
            return true;
        }
        public int GetMode1()
        {
            return 0;
        }
        public int GetMode2()
        {
            return 0;
        }
        public string GetActionOver1()
        {
            return "";
        }
        public string GetActionOver2()
        {
            return "";
        }
        public string GetActionUnder1()
        {
        return "";
        }
        public string GetActionUnder2()
        {
            return "";
        }
        public string GetScheme1()
        {
            return "";
        }

        public int SetID()
        {
            return 0;
        }
        public string SetName()
        {
            return "";
        }
        public int SetType()
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
        public string SetMonitoredValue()
        {
            return "";
        }

        public double SetThresholdNormal()
        {
            return 0.0;
        }
        public int SetMinOverThresholdDuration()
        {
            return 0;
        }
        public int SetMinUnderThresholdDuration()
        {
            return 0;
        }
        public string SetActiveTime()
        {
            return "";
        }
        public int SetDuration()
        {
            return 0;
        }
        public double SetMonitoredValue1()
        {
            return 0.0;
        }
        public double SetThresholdNormal1()
        {
            return 0.0;
        }
        public double SetThresholdEmergency1()
        {
            return 0.0;
        }
        public int SetMinOverThresholdDuration1()
        {
            return 0;
        }
        public int SetMinUnderThresholdDuration1()
        {
            return 0;
        }
        public string SetActiveTimeRelay1_1()
        {
            return "";
        }

        public int SetDurationDelay1_1()
        {
            return 0;
        }
        public bool SetRelayEnabled1()
        {
            return true;
        }
        public int SetMode1()
        {
            return 0;
        }
        public int SetMode2()
        {
            return 0;
        }
        public string SetActionOver1()
        {
            return "";
        }
        public string SetActionOver2()
        {
            return "";
        }
        public string SetActionUnder1()
        {
            return "";
        }
        public string SetActionUnder2()
        {
            return "";
        }
        public string SetScheme1()
        {
            return "";
        }

    }
}
