using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IACHV_Customer_SET
    {
        string SetCustomerUserName();
        string SetCustomerFirstName();
        string SetCustomerLastName();
        string SetCustomerAccountNumber();
        string SetCustomerIdentityID();
        int SetCustomerType();
        int SetCustomerStatus();
        int SetCustomerSex();
        string SetCustomerTel();
        string SetCustomerMobile();
        string SetCustomerEmail();
        string SetCustomerAddress();
        string SetCustomerPostalCode();
        DateTime SetCustomerCreatedOnDate();
        string SetCustomerCreatedBy();
        DateTime SetCustomerModifiedOnDate();
        string SetCustomerModifiedBy();
    }
}
