using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_User_Subscribe_GET
    {
        int GetUserID();
        int GetViaEmail();
        int GetViaSMS();
        int GetViaSys();
        int GetEvent();
        int GetLogin();
        int GetOrderReversal();
        int GetMerchantCredit();
    }
}
