using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ILog_Operating_GET
    {
        string GetSettionID();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        string GetUrl();
        string GetIP();
        string GetForms();
        int Get_Type();
        string GetDescr();
    }
}
