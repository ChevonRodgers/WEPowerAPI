using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_FeeInd_SET
    {
        int SetID();
        string SetName();
        string SetDescr();
        int SetStatus();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
