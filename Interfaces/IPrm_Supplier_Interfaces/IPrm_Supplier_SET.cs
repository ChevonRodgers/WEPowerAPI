using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_Supplier_SET
    {
        int SetID();
        string SetName();
        string SetHttp();
        string SetAddress();
        string SetDescr();
        string SetBizContactPerson();
        string SetTel();
        string SetEmail();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
