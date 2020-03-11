using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Models
{
    public class EmergencyLoadControl
    {
        string MSNO { get; set; }
        string POCSN { get; set; }
        string PowerGridName { get; set; }

        string CustomerName { get; set; }

        string CustomerAddress { get; set; }
        DateTime StartTime { get; set; }
        int Duration { get; set; }
        int CurrentA { get; set; }
        DateTime ExecuteTime { get; set; }
        int ExecuteResult { get; set; }
    }
}
