using System;
using Core.Selenium;
using OpenQA.Selenium;
namespace SalesforceAutomation.Page
{
    public abstract class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage()
        {
            Driver = Browser.Instance.Driver;
        }
    }
}