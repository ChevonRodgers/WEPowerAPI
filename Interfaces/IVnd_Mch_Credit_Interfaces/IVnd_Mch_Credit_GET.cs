using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IVnd_Mch_Credit_GET
    {
        int GetID();
        int GetMCH_ID();
        double GetAmount();
        string GetRefNo();
        int GetPayMethod();
        int GetStatus();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
