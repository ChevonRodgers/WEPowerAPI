using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Sys_Notice_User_Repository: ISys_Notice_User_Repository
    {
        SmartLoadManagementContext db;
        public Sys_Notice_User_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetNoticeID()
        {
            return 0;
        }
        public int GetUserID()
        {
            return 0;
        }
        public int GetStatus()
        {
            return 0;
        }
        public int SetNoticeID()
        {
            return 0;
        }
        public int SetUserID()
        {
            return 0;
        }
        public int SetStatus()
        {
            return 0;
        }
    }
}
