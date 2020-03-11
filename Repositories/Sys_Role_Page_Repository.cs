using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Sys_Role_Page_Repository: ISys_Role_Page_Repository
    {
        SmartLoadManagementContext db;
        public Sys_Role_Page_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetRoleID()
        {
            return 0;
        }
        public int GetPageID()
        {
            return 0;
        }
        public int SetRoleID()
        {
            return 0;
        }
        public int SetPageID()
        {
            return 0;
        }
    }
}
