using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_Notice_User_GET
    {
        int GetNoticeID();
        int GetUserID();
        int GetStatus();
    }
}
