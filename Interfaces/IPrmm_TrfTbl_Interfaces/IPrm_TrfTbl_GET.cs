using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_TrfTbl_GET
    {
        int GetID();
        int GetTrfInd_ID();
        DateTime GetBeginDate();
        string GetScheme();
        int GetStatus();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
