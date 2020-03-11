using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_Notice_SET
    {
        int SetID();
        string SetTitle();
        string SetDescr();
        DateTime SetStartTime();
        DateTime SetDeadLine();
        int SetNoticeAll();
        int SetHits();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
