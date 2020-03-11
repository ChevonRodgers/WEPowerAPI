using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IVnd_Mch_User_SET
    {
        int SetMCH_ID();
        int SetUser_ID();
        DateTime SetCreatedDate();
        int SetCreatedBy();
    }
}
