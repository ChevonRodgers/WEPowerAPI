using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Log_Operating_Repository: ILog_Operating_Repository
    {
        SmartLoadManagementContext db;
        public Log_Operating_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public string GetSettionID()
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
        public string GetUrl()
        {
            return "";
        }
        public string GetIP()
        {
            return "";
        }
        public string GetForms()
        {
            return "";
        }
        public int Get_Type()
        {
            return 0;
        }
        public string GetDescr()
        {
            return "";
        }
        public string SetSettionID()
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
        public string SetUrl()
        {
            return "";
        }
        public string SetIP()
        {
            return "";
        }
        public string SetForms()
        {
            return "";
        }
        public int Set_Type()
        {
            return 0;
        }
        public string SetDescr()
        {
            return "";
        }
    }
}
