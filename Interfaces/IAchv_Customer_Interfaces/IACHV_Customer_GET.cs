using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IACHV_Customer_GET
    {
        string GetCustomerUserName();
        string GetCustomerFirstName();
        string GetCustomerLastName();
        string GetCustomerAccountNumber();
        string GetCustomerIdentityID();
        int GetCustomerType();
        int GetCustomerStatus();
        int GetCustomerSex();
        string GetCustomerTel();
        string GetCustomerMobile();
        string GetCustomerEmail();
        string GetCustomerAddress();
        string GetCustomerPostalCode();
        DateTime GetCustomerCreatedOnDate();
        string GetCustomerCreatedBy();
        DateTime GetCustomerModifiedOnDate();
        string GetCustomerModifiedBy();
    }
}
