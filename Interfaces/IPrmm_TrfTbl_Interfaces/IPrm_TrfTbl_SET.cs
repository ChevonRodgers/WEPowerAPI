using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_TrfTbl_SET
    {
        int SetID();
        int GetTrfInd_ID();
        DateTime SetBeginDate();
        string SetScheme();
        int SetStatus();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
