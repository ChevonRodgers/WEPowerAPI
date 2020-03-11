using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_PowerGrid_GET
    {
        int GetID();
        int GetPID();
        int GetPowerGridType();
        string GetSN();
        string GetName();
        int GetVoltageGrade();
        int GetStatus();
        string GetLng();
        string GetLat();
        string GetDescr();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();

    }
}
