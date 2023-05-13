using System;
using Core.Models;
using Core.Selenium;
using Core.Selenium.Elements;

namespace BusinessObject
{
    public class LoginPage
    {
        Input UserNameInput = new Input("username");
        Input PasswordInput = new Input("pw");
        Button LoginButton = new Button("Login");

        public LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl("https://zayatsco-dev-ed.develop.lightning.force.com");
            return this;
        }

        public void Login(User user)
        {
            UserNameInput.FillIn(user.Name);
            PasswordInput.FillIn(user.Password);
            LoginButton.Click();
        }
    }
}

