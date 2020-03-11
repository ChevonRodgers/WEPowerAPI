using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_Collect_SET
    {
        int SetID();
        int SetCommProtocol();
        string SetName();
        int SetStatus();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
