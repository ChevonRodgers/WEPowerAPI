﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface ISys_UserGroup_GET
    {
        int GetID();
        string GetName();
        int GetStatus();
        string GetDescr();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
    }
}
