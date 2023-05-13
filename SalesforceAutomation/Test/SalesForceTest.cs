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
        [Test]
        public void Test()
        {
            //var
            var standartUser = UserBuilder.StandartUser;

            //Action
            LoginPage
                .OpenLoginPage()
                .Login(standartUser)
                .OpenAccountsPage()
                .CreateAccount(standartUser.Name, standartUser.Password);           

            //Assert
        }
    }
}

