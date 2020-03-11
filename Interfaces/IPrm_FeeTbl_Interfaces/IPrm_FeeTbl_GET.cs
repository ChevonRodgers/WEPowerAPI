using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_FeeTbl_GET
    {
        int GetID();
        int GetFeeInd_ID();
        int GetFeeType();
        string GetName();
        double GetValue();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
