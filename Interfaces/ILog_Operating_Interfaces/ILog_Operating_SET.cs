using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ILog_Operating_SET
    {
        string SetSettionID();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        string SetUrl();
        string SetIP();
        string SetForms();
        int Set_Type();
        string SetDescr();
    }
}
