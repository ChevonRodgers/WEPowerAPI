using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Sys_Notice_Repository: ISys_Notice_Repository
    {
        SmartLoadManagementContext db;
        public Sys_Notice_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public string GetTitle()
        {
            return "";
        }
        public string GetDescr()
        {
            return "";
        }
        public DateTime GetStartTime()
        {
            return DateTime.Now;
        }
        public DateTime GetDeadLine()
        {
            return DateTime.Now;
        }
        public int GetNoticeAll()
        {
            return 0;
        }
        public int GetHits()
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
        public DateTime GetModifiedDate()
        {
            return DateTime.Now;
        }
        public int GetModifiedBy()
        {
            return 0;
        }
        public int SetID()
        {
            return 0;
        }
        public string SetTitle()
        {
            return "";
        }
        public string SetDescr()
        {
            return "";
        }
        public DateTime SetStartTime()
        {
            return DateTime.Now;
        }
        public DateTime SetDeadLine()
        {
            return DateTime.Now;
        }
        public int SetNoticeAll()
        {
            return 0;
        }
        public int SetHits()
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
        public DateTime SetModifiedDate()
        {
            return DateTime.Now;
        }
        public int SetModifiedBy()
        {
            return 0;
        }
    }
}
