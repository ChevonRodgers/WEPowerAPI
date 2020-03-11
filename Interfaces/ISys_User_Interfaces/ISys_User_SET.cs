using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_User_SET
    {
        int SetID();
        int SetRole_ID();
        string SetUsername();
        string SetEmail();
        string SetMobile();
        string SetPassword();
        int SetStatus();
        string SetFirstName();
        string SetLastName();
        int SetGender();
        string SetTel();
        string SetAddress();
        DateTime SetDeadline();
        DateTime SetLatestMDFPWD();
        DateTime SetLatestLogin();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
