using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_MeterType_GET
    {
        int GetID();
        string GetName();
        int GetSuppliedID();
        string GetDescr();
        int GetCommProtocol();
        int GetCommType();
        string GetConnectType();
        bool GetIsCascade();
        double GetAccuracy();
        int GetVoltageGrade();
        int GetCurrentGrade();
        int GetCreditType();
        string GetVersionSoftware();
        string GetVersionHardware();
        int GetKWH_Decimal_Digits();
        int GetKVarh_Decimal_Digits();
        int GetKvah_Decimal_Digits();
        int GetKw_Decimal_Digits();
        int GetKvar_Decimal_Digits();
        int GetKva_Decimal_Digits();
        int GetPf_Decimal_Digits();
        int GetA_Decimal_Digits();
        int GetHz_Decimal_Digits();
        int GetCredit_Decimal_Digits();
        int GetAngle_Decimal_Digits();
        int GetW_Decimal_Digits();
        int GetVar_Decimal_Digits();
        DateTime GetCreatedDate();
        int GetCreatedBy();
        DateTime GetModifiedDate();
        int GetModifiedBy();

    }
}
