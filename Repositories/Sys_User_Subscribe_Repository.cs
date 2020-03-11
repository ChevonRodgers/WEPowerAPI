using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Sys_User_Subscribe_Repository: ISys_User_Subscribe_Repository
    {
        SmartLoadManagementContext db;
        public Sys_User_Subscribe_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetUserID()
        {
            return 0;
        }
        public int GetViaEmail()
        {
            return 0;
        }
        public int GetViaSMS()
        {
            return 0;
        }
        public int GetViaSys()
        {
            return 0;
        }
        public int GetEvent()
        {
            return 0;
        }
        public int GetLogin()
        {
            return 0;
        }
        public int GetOrderReversal()
        {
            return 0;
        }
        public int GetMerchantCredit()
        {
            return 0;
        }
        public int SetUserID()
        {
            return 0;
        }
        public int SetViaEmail()
        {
            return 0;
        }
        public int SetViaSMS()
        {
            return 0;
        }
        public int SetViaSys()
        {
            return 0;
        }
        public int SetEvent()
        {
            return 0;
        }
        public int SetLogin()
        {
            return 0;
        }
        public int SetOrderReversal()
        {
            return 0;
        }
        public int SetMerchantCredit()
        {
            return 0;
        }
    }
}
