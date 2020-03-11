using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Log_Msg_Repository: ILog_Msg_Repository
    {
        SmartLoadManagementContext db;
        public Log_Msg_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public DateTime GetCreatedDate()
        {
            return DateTime.Now;
        }
        public int GetCreatedBy()
        {
            return 0;
        }
        public int GetSendTo()
        {
            return 0;
        }
        public string GetMsg()
        {
            return "";
        }
        public int GetStatus()
        {
            return 0;
        }
        public int SetID()
        {
            return 0;
        }
        public DateTime SetCreatedDate()
        {
            return DateTime.Now;
        }
        public int SetCreatedBy()
        {
            return 0;
        }
        public int SetSendTo()
        {
            return 0;
        }
        public string SetMsg()
        {
            return "";
        }
        public int SetStatus()
        {
            return 0;
        }
    }
}
