using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using BusinessObject.Page;
using Core.Selenium;
using BusinessObject;
using Core.Utilities;

namespace SalesforceAutomation.Test
{
    public class BaseTest
    {
        public LoginPage LoginPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            LoginPage = new LoginPage();
            var standartUser = UserBuilder.StandartUser;

            LoginPage
                .OpenLoginPage()
                .Login(standartUser);
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}
