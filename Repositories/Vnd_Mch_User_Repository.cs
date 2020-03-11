using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Vnd_Mch_User_Repository: IVnd_Mch_User_Repository
    {
        SmartLoadManagementContext db;
        public Vnd_Mch_User_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetMCH_ID()
        {
            return 0;
        }
        public int GetUser_ID()
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
        public int SetMCH_ID()
        {
            return 0;
        }
        public int SetUser_ID()
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
    }
}
