using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_Collect_Plan_GET
    {
        int GetID();
        int GetCollectID();
        string GetName();
        string Get_Type();
        int GetCollectInterval();
        int GetCollectUnit();
        int GetMeteringInterval();
        int GetMetergingUnit();
        int GetOffset();
        int GetOffsetUnit();
        int GetRetryTimes();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();

    }
}
