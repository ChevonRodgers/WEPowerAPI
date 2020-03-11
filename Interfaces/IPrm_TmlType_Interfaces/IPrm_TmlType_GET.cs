using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_TmlType_GET
    {
        int GetID();
        int GetSupplierId();
        string GetName();
        string GetDescr();
        int GetCommProtocol();
        int GetCommType();
        int GetMeterCommType();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
