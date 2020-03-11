using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Log_Password_Repository: ILog_Password_Repository
    {
        SmartLoadManagementContext db;
        public Log_Password_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetUser_ID()
        {
            return 0;
        }
        public string GetPassword()
        {
            return "";
        }
        public DateTime GetCreatedDate()
        {
            return DateTime.Now;
        }
        public int GetCreatedBy()
        {
            return 0;
        }
        public int SetUser_ID()
        {
            return 0;
        }
        public string SetPassword()
        {
            return "";
        }
        public DateTime SetCreatedDate()
        {
            return DateTime.Now;
        }
        public int SetCreatedBy()
        {
            return 0;
        }
    }
}
