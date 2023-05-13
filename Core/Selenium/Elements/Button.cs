using System;
using OpenQA.Selenium;

namespace Core.Selenium.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator) : base(locator)
        {
        }

        public Button(string locator) : base($"//input[@name='{locator}']")
        {
        }
    }
}

