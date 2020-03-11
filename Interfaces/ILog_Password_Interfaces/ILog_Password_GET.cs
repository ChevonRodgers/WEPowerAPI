using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ILog_Password_GET
    {
        int GetUser_ID();
        string GetPassword();
        DateTime GetCreatedDate();
        int GetCreatedBy();
    }
}
