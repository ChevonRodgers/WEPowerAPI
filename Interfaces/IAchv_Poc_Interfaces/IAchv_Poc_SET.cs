using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_Poc_SET
    {
        int SetID();
        string SetSN();
        int SetStatus();
        int SetMeterID();
        int SetPowerGridID();
        int SetCustomerID();
        string SetAddress();
        int SetTrfIndID();
        int SetSGID();
        string SetCT();
        string SetPT();
        int SetCTPRatio();
        int SetCapacity();
        int SetVoltageGrade();
        string SetLng();
        string SetLat();
        string SetDescr();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
