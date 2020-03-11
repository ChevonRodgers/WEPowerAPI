using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_Sim_GET
    {
        int GetID();
        int GetSupplierID();
        string GetSimNo();
        string GetSimICCID();
        int GetSimModel();
        string GetSimIP();
        int GetSimPort();
        string GetSimAPN();
        int GetStatus();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
