using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Interfaces;
using SmartLoadManagement.Models;

namespace SmartLoadManagement.Repositories
{
    public class SmartLoadManagementDataRequirementsRepository: ISmartLoadManagementDataRequirementsRepository
    {
        SmartLoadManagementContext db;

        public SmartLoadManagementDataRequirementsRepository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public List<SmartLoadManagement.Models.EmergencyLoadControl> GetEmergencyLoadControlResults(int? powerGridId, string? powerGridName, int? customerLevel, int? executeResult, string? MSNO, DateTime? startTime, int? duration, int? currentAmperage)
        {
            return new List<SmartLoadManagement.Models.EmergencyLoadControl>();
        }
    }
}
