using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Sys_User_Repository: ISys_User_Repository
    {
        SmartLoadManagementContext db;
        public Sys_User_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetRole_ID()
        {
            return 0;
        }
        public string GetUsername()
        {
            return "";
        }
        public string GetEmail()
        {
            return "";
        }
        public string GetMobile()
        {
            return "";
        }
        public string GetPassword()
        {
            return "";
        }
        public int GetStatus()
        {
            return 0;
        }
        public string GetFirstName()
        {
            return "";
        }
        public string GetLastName()
        {
            return "";
        }
        public int GetGender()
        {
            return 0;
        }
        public string GetTel()
        {
            return "";
        }
        public string GetAddress()
        {
            return "";
        }
        public DateTime GetDeadline()
        {
            return DateTime.Now;
        }
        public DateTime GetLatestMDFPWD()
        {
            return DateTime.Now;
        }
        public DateTime GetLatestLogin()
        {
            return DateTime.Now;
        }
        public DateTime GetCreatedDate()
        {
            return DateTime.Now;
        }
        public int GetCreatedBy()
        {
            return 0;
        }
        public DateTime GetModifiedDate()
        {
            return DateTime.Now;
        }
        public int GetModifiedBy()
        {
            return 0;
        }
        public int SetID()
        {
            return 0;
        }
        public int SetRole_ID()
        {
            return 0;
        }
        public string SetUsername()
        {
            return "";
        }
        public string SetEmail()
        {
            return "";
        }
        public string SetMobile()
        {
            return "";
        }
        public string SetPassword()
        {
            return "";
        }
        public int SetStatus()
        {
            return 0;
        }
        public string SetFirstName()
        {
            return "";
        }
        public string SetLastName()
        {
            return "";
        }
        public int SetGender()
        {
            return 0;
        }
        public string SetTel()
        {
            return "";
        }
        public string SetAddress()
        {
            return "";
        }
        public DateTime SetDeadline()
        {
            return DateTime.Now;
        }
        public DateTime SetLatestMDFPWD()
        {
            return DateTime.Now;
        }
        public DateTime SetLatestLogin()
        {
            return DateTime.Now;
        }
        public DateTime SetCreatedDate()
        {
            return DateTime.Now;
        }
        public int SetCreatedBy()
        {
            return 0;
        }
        public DateTime SetModifiedDate()
        {
            return DateTime.Now;
        }
        public int SetModifiedBy()
        {
            return 0;
        }
    }
}
