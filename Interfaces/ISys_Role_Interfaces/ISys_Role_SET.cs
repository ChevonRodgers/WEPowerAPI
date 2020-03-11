using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_Role_SET
    {
        int SETID();
        string SETName();
        int SETStatus();
        string SETDescr();
        DateTime SETCreatedDate();
        int SETCreatedBy();
        DateTime SETModifiedDate();
        int SETModifiedBy();
    }
}
