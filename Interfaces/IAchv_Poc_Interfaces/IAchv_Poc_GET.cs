using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_Poc_GET
    {
        int GetID();
        string GetSN();
        int GetStatus();
        int GetMeterID();
        int GetPowerGridID();
        int GetCustomerID();
        string GetAddress();
        int GetTrfIndID();
        int GetSGID();
        string GetCT();
        string GetPT();
        int GetCTPRatio();
        int GetCapacity();
        int GetVoltageGrade();
        string GetLng();
        string GetLat();
        string GetDescr();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();

    }
}
