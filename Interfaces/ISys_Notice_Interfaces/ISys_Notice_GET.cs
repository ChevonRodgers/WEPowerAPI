using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_Notice_GET
    {
        int GetID();
        string GetTitle();
        string GetDescr();
        DateTime GetStartTime();
        DateTime GetDeadLine();
        int GetNoticeAll();
        int GetHits();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
