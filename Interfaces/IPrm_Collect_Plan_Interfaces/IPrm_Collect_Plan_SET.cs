using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_Collect_Plan_SET
    {
        int SetID();
        int SetCollectID();
        string SetName();
        string SetType();
        int SetCollectInterval();
        int SetCollectUnit();
        int SetMeteringInterval();
        int SetMetergingUnit();
        int SetOffset();
        int SetOffsetUnit();
        int SetRetryTimes();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
