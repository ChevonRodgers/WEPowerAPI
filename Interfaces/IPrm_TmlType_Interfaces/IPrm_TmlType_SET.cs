using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_TmlType_SET
    {
        int SetID();
        int SetSupplierId();
        string SetName();
        string SetDescr();
        int SetCommProtocol();
        int SetCommType();
        int SetMeterCommType();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
