using NUnit.Framework;
using Core.Selenium;
using System;
using Core.Utilities;
using Core.Models;
using BusinessObject.Page;

namespace SalesforceAutomation.Test
{
    public class SalesForceAccountsTest : BaseTest
    {
        public AccountsPage AccountsPage { get; set; }
        
        [SetUp]
        public void SetUp()
        {            
            AccountsPage = new AccountsPage().OpenAccountsPage();
        }

        //[Test]
        //public void CreateNewAccount()
        //{
        //    //Action
        //    AccountsPage.CreateNewAccount(AccountBuilder.GetRandomAccount());

        //    //Assert
        //}

        //[Test]
        //public void EditAccount()
        //{
        //    //Action
        //    AccountsPage.EditAccount(AccountBuilder.GetRandomAccount());

        //    //Assert
        //}

        //[Test]
        //public void DeleteAccount()
        //{
        //    //Action
        //    AccountsPage.DeleteAccount(AccountBuilder.GetRandomAccount());

        //    //Assert
        //}
    }
}

