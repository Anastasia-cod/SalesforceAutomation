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
        public AccountsPage AccountsPage { get; set; }
        public ContactsPage ContactsPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            ContactsPage = new ContactsPage().OpenContactsPage();
        }

        [Test]
        public void CreateNewContact()
        {
            //var
            //Action
            AccountsPage = new AccountsPage()
                .OpenAccountsPage()
                .CreateNewAccount(AccountBuilder.GetRandomAccount());

            ContactsPage.OpenContactsPage().CreateNewContact(AccountBuilder.GetRandomAccount());
            //Assert
        }

        //[Test]
        //public void EditContact()
        //{
        //    //var
        //    //Action
        //    ContactsPage.EditContact(AccountBuilder.GetRandomAccount());
        //    //Assert
        //}

        //[Test]
        //public void DeleteContact()
        //{
        //    //var
        //    //Action
        //    ContactsPage.DeleteContact(AccountBuilder.GetRandomAccount());
        //    //Assert
        //}
    }
}

