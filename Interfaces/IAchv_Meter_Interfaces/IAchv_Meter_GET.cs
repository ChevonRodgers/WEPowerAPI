using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_Meter_GET
    {
        int GetID();
        string GetMSNO();
        int GetStatus();
        int GetMeterTypeID();
        int GetPrmCollectID();
        int GetPrmDeviceID();
        int GetSimID();
        string GetAssetNo();
        string GetDescr();
        int GetKRN();
        int GetTI();
        int GetKEN();
        int GetSGC();
        DateTime GetLastVending();
        DateTime GetLastFreeVending();
        double GetCurrentMonthUnits();
        double GetCurrentMonthMoney();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();
        int GetDLMSAuthentication();
        string GetDLMSPassword();
        int GetDLMSAESGCM128();
        string GetDLMSAK();
        string GetDLMSEK();
        int GetIsRegister();
        int GetPrm_CFG_ID();

    }
}
