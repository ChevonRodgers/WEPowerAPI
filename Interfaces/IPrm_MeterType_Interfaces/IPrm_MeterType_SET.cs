using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLoadManagement.Interfaces
{
    public interface IPrm_MeterType_SET
    {
        int SetID();
        string SetName();
        int SetSuppliedID();
        string SetDescr();
        int SetCommProtocol();
        int SetCommType();
        string SetConnectType();
        bool SetIsCascade();
        double SetAccuracy();
        int SetVoltageGrade();
        int SetCurrentGrade();
        int SetCreditType();
        string SetVersionSoftware();
        string SetVersionHardware();
        int SetKWH_Decimal_Digits();
        int SetKVarh_Decimal_Digits();
        int SetKvah_Decimal_Digits();
        int SetKw_Decimal_Digits();
        int SetKvar_Decimal_Digits();
        int SetKva_Decimal_Digits();
        int SetPf_Decimal_Digits();
        int SetA_Decimal_Digits();
        int SetHz_Decimal_Digits();
        int SetCredit_Decimal_Digits();
        int SetAngle_Decimal_Digits();
        int SetW_Decimal_Digits();
        int SetVar_Decimal_Digits();
        DateTime SetCreatedDate();
        int SetCreatedBy();
        DateTime SetModifiedDate();
        int SetModifiedBy();
    }
}
