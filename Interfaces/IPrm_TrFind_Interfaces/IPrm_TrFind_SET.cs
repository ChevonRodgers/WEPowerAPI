using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_TrFind_SET
    {
        int SetID();
        int SetfeeIng_ID();
        int SetTI();
        int Set_Type();
        string SetName();
        string SetDescr();
        int SetStatus();
        string SetFriendlyTime();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
