using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_LoadCtrl_GET
    {
        int GetID();
        string GetName();
        int Get_Type();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
        string GetMonitoredValue();
        double GetThresholdNormal();
        int GetMinOverThresholdDuration();
        int GetMinUnderThresholdDuration();
        string GetActiveTime();
        int GetDuration();
        double GetMonitoredValue1();
        double GetThresholdNormal1();
        double GetThresholdEmergency1();
        int GetMinOverThresholdDuration1();
        int GetMinUnderThresholdDuration1();
        string GetActiveTimeRelay1_1();
        int GetDurationDelay1_1();
        bool GetRelayEnabled1();
        int GetMode1();
        int GetMode2();
        string GetActionOver1();
        string GetActionOver2();
        string GetActionUnder1();
        string GetActionUnder2();
        string GetScheme1();

    }
}
