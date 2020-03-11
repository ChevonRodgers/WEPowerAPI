using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ILog_Login_GET
    {
        string GetSessionID();
        int GetCreatedBy();
        DateTime GetCreatedDate();
        string GetIP();
        string Get_Type();
        string GetBrowse();
        string GetOS();
    }
}
