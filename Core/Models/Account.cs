using System;
namespace Core.Models
{
    public class Account
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountSite { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string OwnerShip { get; set; }
        public string Type { get; set; }
        public string BillingStreet { get; set; }
        public string editAccount = "Edit";
        public string changeOwnerAccount = "Change Owner";
        public string deleteAccount = "Delete";
    }
}

