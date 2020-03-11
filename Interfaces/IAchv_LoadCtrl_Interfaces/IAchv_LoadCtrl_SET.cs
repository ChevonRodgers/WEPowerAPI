using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_LoadCtrl_SET
    {
        int SetID();
        string SetName();
        int SetType();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
        string SetMonitoredValue();
        double SetThresholdNormal();
        int SetMinOverThresholdDuration();
        int SetMinUnderThresholdDuration();
        string SetActiveTime();
        int SetDuration();
        double SetMonitoredValue1();
        double SetThresholdNormal1();
        double SetThresholdEmergency1();
        int SetMinOverThresholdDuration1();
        int SetMinUnderThresholdDuration1();
        string SetActiveTimeRelay1_1();
        int SetDurationDelay1_1();
        bool SetRelayEnabled1();
        int SetMode1();
        int SetMode2();
        string SetActionOver1();
        string SetActionOver2();
        string SetActionUnder1();
        string SetActionUnder2();
        string SetScheme1();
    }
}
