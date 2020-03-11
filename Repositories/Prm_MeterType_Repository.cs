using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Prm_MeterType_Repository : IPrm_MeterType_Repository
    {
        SmartLoadManagementContext db;
        public Prm_MeterType_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public int GetID()
        {
            return 0;
        }
        public string GetName()
        {
            return "";
        }
        public int GetSuppliedID()
        {
            return 0;
        }
        public string GetDescr()
        {
            return "";
        }
        public int GetCommProtocol()
        {
            return 0;
        }
        public int GetCommType()
        {
            return 0;
        }
        public string GetConnectType()
        {
            return "";
        }
        public bool GetIsCascade()
        {
            return true;
        }
        public double GetAccuracy()
        {
            return 0.0;
        }
        public int GetVoltageGrade()
        {
            return 0;
        }
        public int GetCurrentGrade()
        {
            return 0;
        }
        public int GetCreditType()
        {
            return 0;
        }
        public string GetVersionSoftware()
        {
            return "";
        }
        public string GetVersionHardware()
        {
            return "";
        }
        public int GetKWH_Decimal_Digits()
        {
            return 0;
        }
        public int GetKVarh_Decimal_Digits()
        {
            return 0;
        }
        public int GetKvah_Decimal_Digits()
        {
            return 0;
        }
        public int GetKw_Decimal_Digits()
        {
            return 0;
        }
        public int GetKvar_Decimal_Digits()
        {
            return 0;
        }
        public int GetKva_Decimal_Digits()
        {
            return 0;
        }
        public int GetPf_Decimal_Digits()
        {
            return 0;
        }
        public int GetA_Decimal_Digits()
        {
            return 0;
        }
        public int GetHz_Decimal_Digits()
        {
            return 0;
        }
        public int GetCredit_Decimal_Digits()
        {
            return 0;
        }
        public int GetAngle_Decimal_Digits()
        {
            return 0;
        }
        public int GetW_Decimal_Digits()
        {
            return 0;
        }
        public int GetVar_Decimal_Digits()
        {
            return 0;
        }
        public DateTime GetCreatedDate()
        {
            return DateTime.Now;
        }
        public int GetCreatedBy()
        {
            return 0;
        }
        public DateTime GetModifiedDate()
        {
            return DateTime.Now;
        }
        public int GetModifiedBy()
        {
            return 0;
        }
        public int SetID()
        {
            return 0;
        }
        public string SetName()
        {
            return "";
        }
        public int SetSuppliedID()
        {
            return 0;
        }
        public string SetDescr()
        {
            return "";
        }
        public int SetCommProtocol()
        {
            return 0;
        }
        public int SetCommType()
        {
            return 0;
        }
        public string SetConnectType()
        {
            return "";
        }
        public bool SetIsCascade()
        {
            return true;
        }
        public double SetAccuracy()
        {
            return 0.0;
        }
        public int SetVoltageGrade()
        {
            return 0;
        }
        public int SetCurrentGrade()
        {
            return 0;
        }
        public int SetCreditType()
        {
            return 0;
        }
        public string SetVersionSoftware()
        {
            return "";
        }
        public string SetVersionHardware()
        {
            return "";
        }
        public int SetKWH_Decimal_Digits()
        {
            return 0;
        }
        public int SetKVarh_Decimal_Digits()
        {
            return 0;
        }
        public int SetKvah_Decimal_Digits()
        {
            return 0;
        }
        public int SetKw_Decimal_Digits()
        {
            return 0;
        }
        public int SetKvar_Decimal_Digits()
        {
            return 0;
        }
        public int SetKva_Decimal_Digits()
        {
            return 0;
        }
        public int SetPf_Decimal_Digits()
        {
            return 0;
        }
        public int SetA_Decimal_Digits()
        {
            return 0;
        }
        public int SetHz_Decimal_Digits()
        {
            return 0;
        }
        public int SetCredit_Decimal_Digits()
        {
            return 0;
        }
        public int SetAngle_Decimal_Digits()
        {
            return 0;
        }
        public int SetW_Decimal_Digits()
        {
            return 0;
        }
        public int SetVar_Decimal_Digits()
        {
            return 0;
        }
        public DateTime SetCreatedDate()
        {
            return DateTime.Now;
        }
        public int SetCreatedBy()
        {
            return 0;
        }
        public DateTime SetModifiedDate()
        {
            return DateTime.Now;
        }
        public int SetModifiedBy()
        {
            return 0;
        }
    }
}


