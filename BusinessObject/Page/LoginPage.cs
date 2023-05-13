using System;
using Core.Models;
using Core.Selenium;
using Core.Selenium.Elements;
using OpenQA.Selenium;

namespace BusinessObject.Page
{
    public class LoginPage : BasePage
    {
        Input userNameInput = new Input(By.XPath("//input[@name='username']"));
        Input passwordInput = new Input(By.XPath("//input[@name='pw']"));
        Button loginButton = new Button(By.XPath("//input[@name='Login']"));

        //$"//input[@name='{locator}']

        public LoginPage OpenLoginPage()
        {
            Browser.Instance.NavigateToUrl("https://zayatsco-dev-ed.develop.lightning.force.com");
            return this;
        }

        public AccountsPage Login(User user)
        {
            userNameInput.FillIn(user.Name);
            passwordInput.FillIn(user.Password);
            loginButton.Click();
            Browser.Instance.NavigateToUrl("https://zayatsco-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            return new AccountsPage();
        }
    }
}

