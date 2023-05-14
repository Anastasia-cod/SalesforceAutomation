using System;
using OpenQA.Selenium;

namespace Core.Selenium.Elements
{
    public class Dropdown : BaseElement
    {
        public Dropdown(By locator) : base(locator)
        {
        }

        public Dropdown(string locator) : base($"//button[contains(@aria-label, '{locator}')]")
        {
        }

        public void Select(string option)
        {
            Browser.Driver.FindElement(Locator).Click();
            Browser.Driver.FindElement(By.XPath($"//lightning-base-combobox-item[@data-value='{option}']")).Click();
        }

        public void SelectForActionWithAccount(string option)
        {
            Browser.Driver.FindElement(Locator).Click();
            Browser.Driver.FindElement(By.XPath($"//lightning-base-combobox-item[@title='{option}']")).Click();
        }

        public void SelectForContact()
        {
            Browser.Driver.FindElement(Locator).Click();
            Browser.Driver.FindElement(By.XPath($"//span[@class='slds-listbox__option-text slds-listbox__option-text_entity']/span")).Click();
        }

        
    }
}

