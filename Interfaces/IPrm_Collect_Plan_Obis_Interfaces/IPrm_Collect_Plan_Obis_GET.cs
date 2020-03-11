using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_Collect_Plan_Obis_GET
    {
        int GetCollectPlanID();
        string GetOBIS();
        int GetOrderNo();
    }
}
