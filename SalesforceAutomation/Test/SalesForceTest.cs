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
                .CreateAccount(standartUser.Name, standartUser.Password);           

            //Assert
        }
    }
}

