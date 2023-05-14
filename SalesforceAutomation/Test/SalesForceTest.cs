using NUnit.Framework;
using Core.Selenium;
using System;
using Core.Utilities;
using Core.Models;
using BusinessObject.Page;

namespace SalesforceAutomation.Test
{
    public class SalesForceTest : BaseTest
    {
        public AccountsPage AccountsPage { get; set; }
        
        [SetUp]
        public void SetUp()
        {            
            AccountsPage = new AccountsPage();
            AccountsPage.OpenAccountsPage();
        }

        [Test]
        public void CreateNewAccount()
        {
            //Action
            AccountsPage.CreateNewAccount(AccountBuilder.GetRandomAccount());

            //Assert
        }

        [Test]
        public void EditFirstCreatedAccount()
        {
            //Action
            AccountsPage.EditAccount(AccountBuilder.GetRandomAccount());

            //Assert
        }

        [Test]
        public void DeleteAccount()
        {
            //Action
            AccountsPage.DeleteAccount(AccountBuilder.GetRandomAccount());

            //Assert
        }
    }
}

