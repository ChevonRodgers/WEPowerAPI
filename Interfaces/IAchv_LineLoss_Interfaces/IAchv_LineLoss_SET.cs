using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_LineLoss_SET
    {
        int SetID();
        string SetName();
        int SetStatus();
        string SetDesc();
        int SetGatewayMeter_ID();
        int SetDayCalc();
        int SetMonthCalc();
        DateTime SetCalc_Latest();
        int SetCalcTimes();
        DateTime SetCalc_MonthLatest();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
