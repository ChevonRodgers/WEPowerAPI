using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_PowerGrid_SET
    {
        int SetID();
        int SetPID();
        int SetPowerGridType();
        string SetSN();
        string SetName();
        int SetVoltageGrade();
        int SetStatus();
        string SetLng();
        string SetLat();
        string SetDescr();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
