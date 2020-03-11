using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IAchv_Meter_SET
    {
        int SetID();
        string SetMSNO();
        int SetStatus();
        int SetMeterTypeID();
        int SetPrmCollectID();
        int SetPrmDeviceID();
        int SetSimID();
        string SetAssetNo();
        string SetDescr();
        int SetKRN();
        int SetTI();
        int SetKEN();
        int SetSGC();
        DateTime SetLastVending();
        DateTime SetLastFreeVending();
        double SetCurrentMonthUnits();
        double SetCurrentMonthMoney();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
        int SetDLMSAuthentication();
        string SetDLMSPassword();
        int SetDLMSAESGCM128();
        string SetDLMSAK();
        string SetDLMSEK();
        int SetIsRegister();
        int SetPrm_CFG_ID();
    }
}
