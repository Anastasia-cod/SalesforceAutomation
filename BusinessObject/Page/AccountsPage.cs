using System;
using Core.Models;
using Core.Selenium;
using Core.Selenium.Elements;
using OpenQA.Selenium;

namespace BusinessObject.Page
{
	public class AccountsPage
	{
        Button newButton = new Button(By.XPath("//div[@title='New']"));
        Button save = new Button(By.XPath("//button[@name='SaveEdit']"));
        Input accountName = new Input(By.XPath("//*[@id=\"input-560\"]"));
        Input website = new Input("Website");

        public AccountsPage OpenAccountsPage()
        {
            Browser.Instance.NavigateToUrl("https://zayatsco-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            return this;
        }

        public void ClickNewButton()
        {
            newButton.Click();
        }

        public void CreateAccount(string accountName, string websiteName)
        {
            this.accountName.FillIn(accountName);
            website.FillIn(websiteName);
            save.Click();
        }
    }
}

