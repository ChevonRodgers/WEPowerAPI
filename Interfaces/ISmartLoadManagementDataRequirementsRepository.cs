using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    interface ISmartLoadManagementDataRequirementsRepository
    {
        List<SmartLoadManagement.Models.EmergencyLoadControl> GetEmergencyLoadControlResults(int? powerGridId, string? powerGridName, int? customerLevel, int? executeResult, string? MSNO, DateTime? startTime, int? duration, int? currentAmperage);
    }
}
