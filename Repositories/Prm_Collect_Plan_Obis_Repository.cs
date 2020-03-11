using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_Collect_Plan_Obis_Repository: IPrm_Collect_Plan_Obis_Repository
    {
        SmartLoadManagementContext db;
        public Prm_Collect_Plan_Obis_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetCollectPlanID()
        {
            return 0;
        }
        public string GetOBIS()
        {
            return "";
        }
        public int GetOrderNo()
        {
            return 0;
        }
        public int SetCollectPlanID()
        {
            return 0;
        }
        public string SetOBIS()
        {
            return "";
        }
        public int SetOrderNo()
        {
            return 0;
        }
    }
}
