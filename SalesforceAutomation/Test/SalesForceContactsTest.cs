using NUnit.Framework;
using Core.Selenium;
using System;
using Core.Utilities;
using Core.Models;
using BusinessObject.Page;

namespace SalesforceAutomation.Test
{
	public class SalesForceContactsTest : BaseTest
	{
        //public AccountsPage AccountsPage { get; set; }
        public ContactsPage ContactsPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            //AccountsPage = new AccountsPage().OpenAccountsPage();
            //AccountsPage.CreateNewAccount(AccountBuilder.GetRandomAccount());

            ContactsPage = new ContactsPage().OpenContactsPage();
        }

        [Test]
        public void CreateNewContact()
        {
            //var
            //Action
            ContactsPage.CreateNewContact(AccountBuilder.GetRandomAccount());
            //Assert
        }

    }
}

