using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_LoadCtrl_Meter_SET
    {
        int SetID();
        int SetLoadCtrlID();
        int SetMeter_ID();
        int SetRetry_Times();
        int SetResult();
        DateTime SetStarTime();
        DateTime SetEndTime();
        DateTime SetCreatedDate();
        int SetCreatedBy();
    }
}
