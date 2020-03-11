using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_Supplier_GET
    {
        int GetID();
        string GetName();
        string GetHttp();
        string GetAddress();
        string GetDescr();
        string GetBizContactPerson();
        string GetTel();
        string GetEmail();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();

    }
}
