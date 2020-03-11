using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Sys_UserGroup_User_Repository: ISys_UserGroup_User_Repository
    {
        SmartLoadManagementContext db;
        public Sys_UserGroup_User_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetUserGroup_ID()
        {
            return 0;
        }
        public int GetUser_ID()
        {
            return 0;
        }
        public int SetUserGroup_ID()
        {
            return 0;
        }
        public int SetUser_ID()
        {
            return 0;
        }
    }
}
