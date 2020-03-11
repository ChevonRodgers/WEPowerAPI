using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_Tml_SET
    {
        int SetID();
        string SetSN();
        int SetStatus();
        string SetIMEI();
        int SetTmlTypeID();
        string SetAssetNo();
        int SetPowerGridID();
        int SetPrm_Collect_ID();
        int SetPrm_Device_ID();
        int SetSimID();
        int SetPrm_Cfg_ID();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
