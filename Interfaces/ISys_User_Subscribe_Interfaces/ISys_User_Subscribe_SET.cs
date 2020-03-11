using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_User_Subscribe_SET
    {
        int SetUserID();
        int SetViaEmail();
        int SetViaSMS();
        int SetViaSys();
        int SetEvent();
        int SetLogin();
        int SetOrderReversal();
        int SetMerchantCredit();
    }
}
