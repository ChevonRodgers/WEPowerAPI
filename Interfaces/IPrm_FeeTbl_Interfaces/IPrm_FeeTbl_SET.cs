using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_FeeTbl_SET
    {
        int SetID();
        int SetFeeInd_ID();
        int SetFeeType();
        string SetName();
        double SetValue();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
