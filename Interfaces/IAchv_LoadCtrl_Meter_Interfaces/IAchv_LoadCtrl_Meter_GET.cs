using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_LoadCtrl_Meter_GET
    {
        int GetID();
        int GetLoadCtrlID();
        int GetMeter_ID();
        int GetRetry_Times();
        int GetResult();
        DateTime GetStarTime();
        DateTime GetEndTime();
        DateTime GetCreatedDate();
        int GetCreatedBy();
    }
}
