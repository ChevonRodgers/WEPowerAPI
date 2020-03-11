using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_Sim_SET
    {
        int SetID();
        int SetSupplierID();
        string SetSimNo();
        string SetSimICCID();
        int SetSimModel();
        string SetSimIP();
        int SetSimPort();
        string SetSimAPN();
        int SetStatus();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
