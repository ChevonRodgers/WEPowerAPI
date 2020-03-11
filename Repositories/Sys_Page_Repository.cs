using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Sys_Page_Repository: ISys_Page_Repository
    {
        SmartLoadManagementContext db;
        public Sys_Page_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public int GetParentID()
        {
            return 0;
        }
        public string GetName()
        {
            return "";
        }
        public string GetURL()
        {
            return "";
        }
        public int GetOrderNo()
        {
            return 0;
        }
        public string GetICO()
        {
            return "";
        }
        public int SetID()
        {
            return 0;
        }
        public int SetParentID()
        {
            return 0;
        }
        public string SetName()
        {
            return "";
        }
        public string SetURL()
        {
            return "";
        }
        public int SetOrderNo()
        {
            return 0;
        }
        public string SetICO()
        {
            return "";
        }
    }
}
