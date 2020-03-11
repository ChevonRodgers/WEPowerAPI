using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Sys_UserGroup_Obj_Repository: ISys_UserGroup_Obj_Repository
    {
        SmartLoadManagementContext db;
        public Sys_UserGroup_Obj_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetUserGroupID()
        {
            return 0;
        }
        public int GetObjID()
        {
            return 0;
        }
        public int SetUserGroupID()
        {
            return 0;
        }
        public int SetObjID()
        {
            return 0;
        }
    }
}
