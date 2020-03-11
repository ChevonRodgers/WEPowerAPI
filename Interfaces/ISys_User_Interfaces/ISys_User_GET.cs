using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_User_GET
    {
        int GetID();
        int GetRole_ID();
        string GetUsername();
        string GetEmail();
        string GetMobile();
        string GetPassword();
        int GetStatus();
        string GetFirstName();
        string GetLastName();
        int GetGender();
        string GetTel();
        string GetAddress();
        DateTime GetDeadline();
        DateTime GetLatestMDFPWD();
        DateTime GetLatestLogin();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();

    }
}
