using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_Device_Deleted_GET
    {
        int GetID();
        string GetName();
        int GetStatus();
        string GetServer();
        int GetPort();
        string GetDescr();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();

    }
}
