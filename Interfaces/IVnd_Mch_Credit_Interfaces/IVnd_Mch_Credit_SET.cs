using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IVnd_Mch_Credit_SET
    {
        int SetID();
        int SetMCH_ID();
        double SetAmount();
        string SetRefNo();
        int SetPayMethod();
        int SetStatus();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
