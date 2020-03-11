using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IVnd_Mch_User_GET
    {
        int GetMCH_ID();
        int GetUser_ID();
        DateTime GetCreatedDate();
        int GetCreatedBy();
    }
}
