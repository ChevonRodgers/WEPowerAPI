using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_SgKey_SET
    {
        int SetID();
        int SetSG_ID();
        int SetKRN();
        int SetKEN();
        DateTime SetDeadLine();
        DateTime SetBaseLine();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
