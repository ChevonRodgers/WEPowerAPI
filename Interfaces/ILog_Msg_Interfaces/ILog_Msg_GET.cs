using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ILog_Msg_GET
    {
        int GetID();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        int GetSendTo();
        string GetMsg();
        int GetStatus();
    }
}
