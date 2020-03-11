using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ILog_Password_SET
    {
        int SetUser_ID();
        string SetPassword();
        DateTime SetCreatedDate();
        int SetCreatedBy();
    }
}
