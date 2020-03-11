using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ILog_Msg_SET
    {
        int SetID();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        int SetSendTo();
        string SetMsg();
        int SetStatus();
    }
}
