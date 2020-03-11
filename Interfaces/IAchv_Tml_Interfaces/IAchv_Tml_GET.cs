using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_Tml_GET
    {
        int GetID();
        string GetSN();
        int GetStatus();
        string GetIMEI();
        int GetTmlTypeID();
        string GetAssetNo();
        int GetPowerGridID();
        int GetPrm_Collect_ID();
        int GetPrm_Device_ID();
        int GetSimID();
        int GetPrm_Cfg_ID();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();

    }
}
