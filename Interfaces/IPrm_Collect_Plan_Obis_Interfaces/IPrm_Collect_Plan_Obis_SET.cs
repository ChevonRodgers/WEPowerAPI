using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_Collect_Plan_Obis_SET
    {
        int SetCollectPlanID();
        string SetOBIS();
        int SetOrderNo();
    }
}
