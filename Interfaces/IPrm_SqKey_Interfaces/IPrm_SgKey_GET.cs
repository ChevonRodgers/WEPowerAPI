using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_SgKey_GET
    {
        int GetID();
        int GetSG_ID();
        int GetKRN();
        int GetKEN();
        DateTime GetDeadLine();
        DateTime GetBaseLine();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
