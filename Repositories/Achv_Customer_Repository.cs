using System;
using SmartLoadManagement.Models;
using SmartLoadManagement.Interfaces;

namespace SmartLoadManagement.Repositories
{
    public class Achv_Customer_Repository: IAchv_Customer_Repository
    {
        SmartLoadManagementContext db;
        public Achv_Customer_Repository()
        {
            this.db = new SmartLoadManagementContext();
        }
        public string GetCustomerUserName()
        {
            return "";
        }
        public string GetCustomerFirstName()
        {
            return "";
        }
        public string GetCustomerLastName()
        {
            return "";
        }
        public string GetCustomerAccountNumber()
        {
            return "";
        }
        public string GetCustomerIdentityID()
        {
            return "";
        }
        public int GetCustomerType()
        {
            return 0;
        }
        public int GetCustomerStatus()
        {
            return 0;
        }
        public int GetCustomerSex()
        {
            return 0;
        }
        public string GetCustomerTel()
        {
            return "";
        }
        public string GetCustomerMobile()
        {
            return "";
        }
        public string GetCustomerEmail()
        {
            return "";
        }
        public string GetCustomerAddress()
        {
            return "";
        }
        public string GetCustomerPostalCode()
        {
            return "";
        }
        public DateTime GetCustomerCreatedOnDate()
        {
            return DateTime.Now;
        }
        public string GetCustomerCreatedBy()
        {
            return "";
        }
        public DateTime GetCustomerModifiedOnDate()
        {
            return DateTime.Now;
        }
        public string GetCustomerModifiedBy()
        {
            return "";
        }
        public string SetCustomerUserName()
        {
            return "";
        }
        public string SetCustomerFirstName()
        {
            return "";
        }
        public string SetCustomerLastName()
        {
            return "";
        }
        public string SetCustomerAccountNumber()
        {
            return "";
        }
        public string SetCustomerIdentityID()
        {
            return "";
        }
        public int SetCustomerType()
        {
            return 0;
        }
        public int SetCustomerStatus()
        {
            return 0;
        }
        public int SetCustomerSex()
        {
            return 0;
        }
        public string SetCustomerTel()
        {
            return "";
        }
        public string SetCustomerMobile()
        {
            return "";
        }
        public string SetCustomerEmail()
        {
            return "";
        }
        public string SetCustomerAddress()
        {
            return "";
        }
        public string SetCustomerPostalCode()
        {
            return "";
        }
        public DateTime SetCustomerCreatedOnDate()
        {
            return DateTime.Now;
        }
        public string SetCustomerCreatedBy()
        {
            return "";
        }
        public DateTime SetCustomerModifiedOnDate()
        {
            return DateTime.Now;
        }
        public string SetCustomerModifiedBy()
        {
            return "";
        }
    }
}
