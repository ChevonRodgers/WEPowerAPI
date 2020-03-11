using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_UserGroup_SET
    {
        int SetID();
        string SetName();
        int SetStatus();
        string SetDescr();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
