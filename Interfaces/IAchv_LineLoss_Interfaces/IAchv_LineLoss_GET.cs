using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_LineLoss_GET
    {
        int GetID();
        string GetName();
        int GetStatus();
        string GetDesc();
        int GetGatewayMeter_ID();
        int GetDayCalc();
        int GetMonthCalc();
        DateTime GetCalc_Latest();
        int GetCalcTimes();
        DateTime GetCalc_MonthLatest();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
