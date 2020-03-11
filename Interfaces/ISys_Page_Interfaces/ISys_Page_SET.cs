using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_Page_SET
    {
        int SetID();
        int SetParentID();
        string SetName();
        string SetURL();
        int SetOrderNo();
        string SetICO();
    }
}
