using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_Device_Deleted_SET
    {
        int SetID();
        string SetName();
        int SetStatus();
        string SetServer();
        int SetPort();
        string SetDescr();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
