using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_TrFind_GET
    {
        int GetID();
        int GetfeeIng_ID();
        int GetTI();
        int Get_Type();
        string GetName();
        string GetDescr();
        int GetStatus();
        string GetFriendlyTime();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();

    }
}
