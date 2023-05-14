﻿using System;
using OpenQA.Selenium;

namespace Core.Selenium.Elements
{
    public class BaseElement
    {
        protected Browser Browser => Browser.Instance;
        protected By Locator { get; }

        public BaseElement(By locator)
        {
            Locator = locator;
        }

        public BaseElement(string locator)
        {
            Locator = By.XPath(locator);
        }

        public void FillIn(string message)
        {
            Browser.Driver.FindElement(Locator).SendKeys(message);
        }

        public void UpdateValue(string message)
        {
            Browser.Driver.FindElement(Locator).Clear();
            Browser.Driver.FindElement(Locator).SendKeys(message);
        }

        public void Click()
        {
            Browser.Driver.FindElement(Locator).Click();
        }
    }
}

