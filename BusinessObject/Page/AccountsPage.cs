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
        Button saveNewAccount = new Button(By.XPath("//button[@name='SaveEdit']"));
        Button saveAnyActionWithAccount = new Button(By.XPath("//button[text()='Save']"));
        Button deleteButton = new Button(By.XPath("//button[@title='Delete']"));
        Input accountName = new Input("Name");
        Input accountNumber = new Input("AccountNumber");
        Input accountSite = new Input("Site");
        Input phone = new Input("Phone");
        Input website = new Input("Website");
        Input billingStreet = new Input(By.XPath("//textarea[@name='street']"));
        Dropdown ownershipDropdown = new Dropdown("Ownership, --None--");
        Dropdown typeDropdown = new Dropdown("Type, --None--");
        Dropdown actionDropdown = new Dropdown(By.XPath("//a[@class ='rowActionsPlaceHolder slds-button slds-button--icon-x-small slds-button--icon-border-filled keyboardMode--trigger']"));

        public AccountsPage OpenAccountsPage()
        {
            Browser.Instance.NavigateToUrl("https://zayatsco-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            return this;
        }

        public AccountsPage CreateNewAccount(Account account)
        {
            newButton.Click();
            accountName.FillIn(account.AccountName);
            accountNumber.FillIn(account.AccountNumber);
            accountSite.FillIn(account.AccountSite);
            phone.FillIn(account.Phone);
            website.FillIn(account.Website);
            billingStreet.FillIn(account.BillingStreet);
            ownershipDropdown.SelectForCreateAcount(account.OwnerShip);
            typeDropdown.SelectForCreateAcount(account.Type);
            saveNewAccount.Click();
            return this;
        }

        public AccountsPage EditAccount(Account account)
        {
            actionDropdown.SelectForActionWithAccount(account.editAccount);
            accountName.UpdateValue(account.AccountName);
            accountNumber.UpdateValue(account.AccountNumber);
            accountSite.UpdateValue(account.AccountSite);
            phone.UpdateValue(account.Phone);
            website.UpdateValue(account.Website);
            billingStreet.UpdateValue(account.BillingStreet);
            saveAnyActionWithAccount.Click();
            return this;
        }

        public AccountsPage DeleteAccount()
        {
            actionDropdown.SelectForActionWithAccount("Delete");
            deleteButton.Click();
            return this;
        }
    }
}

