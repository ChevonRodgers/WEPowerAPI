using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IVnd_Mch_SET
    {
        int SetID();
        int SetStatus();
        string SetSN();
        string SetName();
        string SetContactPerson();
        string SetTel();
        string SetEmail();
        string SetAddress();
        string SetDescr();
        DateTime SetStartTime();
        DateTime SetEndTime();
        double SetCreditAmount();
        double SetCreditLimit();
        double SetVendMinPerTime();
        double SetVendMaxPerTime();
        int SetCommissionType();
        double SetCommissionValue();
        double SetTotalCharge();
        double SetTotalSale();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
