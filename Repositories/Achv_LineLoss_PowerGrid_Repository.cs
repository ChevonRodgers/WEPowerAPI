using SmartLoadManagement.Interfaces;
using SmartLoadManagement.Models;

namespace SmartLoadManagement.Repositories
{
    public class Achv_LineLoss_PowerGrid_Repository: IAchv_LineLoss_PowerGrid_Repository
    {
        SmartLoadManagementContext db;
        public Achv_LineLoss_PowerGrid_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetLineLossID()
        {
            return 0;
        }
        public int GetPowerGridID()
        {
            return 0;
        }
        public int SetLineLossID()
        {
            return 0;
        }
        public int SetPowerGridID()
        {
            return 0;
        }
    }
}
