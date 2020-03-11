using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ILog_Login_SET
    {
        string SetSessionID();
        int SetCreatedBy();
        DateTime SetCreatedDate();
        string SetIP();
        string SetType();
        string SetBrowse();
        string SetOS();
    }
}
