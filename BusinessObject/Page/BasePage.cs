using System;
using Core.Models;
using Core.Selenium;
using Core.Selenium.Elements;
using OpenQA.Selenium;

namespace BusinessObject.Page
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