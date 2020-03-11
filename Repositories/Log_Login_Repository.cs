using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Log_Login_Repository: ILog_Login_Repository
    {
        SmartLoadManagementContext db;
        public Log_Login_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public string GetSessionID()
        {
            return "";
        }
        public int GetCreatedBy()
        {
            return 0;
        }
        public DateTime GetCreatedDate()
        {
            return DateTime.Now;
        }
        public string GetIP()
        {
            return "";
        }
        public string Get_Type()
        {
            return "";
        }
        public string GetBrowse()
        {
            return "";
        }
        public string GetOS()
        {
            return "";
        }
        public string SetSessionID()
        {
            return "";
        }
        public int SetCreatedBy()
        {
            return 0;
        }
        public DateTime SetCreatedDate()
        {
            return DateTime.Now;
        }
        public string SetIP()
        {
            return "";
        }
        public string SetType()
        {
            return "";
        }
        public string SetBrowse()
        {
            return "";
        }
        public string SetOS()
        {
            return "";
        }
    }
}
