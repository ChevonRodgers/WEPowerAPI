using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_Page_GET
    {
        int GetID();
        int GetParentID();
        string GetName();
        string GetURL();
        int GetOrderNo();
        string GetICO();
    }
}
