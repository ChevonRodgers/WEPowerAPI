using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IVnd_Mch_GET
    {
        int GetID();
        int GetStatus();
        string GetSN();
        string GetName();
        string GetContactPerson();
        string GetTel();
        string GetEmail();
        string GetAddress();
        string GetDescr();
        DateTime GetStartTime();
        DateTime GetEndTime();
        double GetCreditAmount();
        double GetCreditLimit();
        double GetVendMinPerTime();
        double GetVendMaxPerTime();
        int GetCommissionType();
        double GetCommissionValue();
        double GetTotalCharge();
        double GetTotalSale();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
