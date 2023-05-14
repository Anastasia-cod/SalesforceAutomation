using System;
using System.Numerics;
using Core.Models;
using Core.Selenium;
using Core.Selenium.Elements;
using OpenQA.Selenium;

namespace BusinessObject.Page
{
    public class ContactsPage : BasePage
    {
        Dropdown salutationDropdown = new Dropdown("Salutation, --None--");
        Dropdown accountNameDropdown = new Dropdown(By.XPath("//input[@placeholder='Search Accounts...']"));
        Button newButton = new Button(By.XPath("//div[@title='New']"));
        Button saveNewContact = new Button("SaveEdit");
        Input firstName = new Input("firstName");
        Input lastName = new Input("lastName");
        Input phone = new Input("Phone");


        public ContactsPage OpenContactsPage()
        {
            Browser.Instance.NavigateToUrl("https://zayatsco-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
            return this;
        }

        public ContactsPage CreateNewContact(Account account)
        {
            newButton.Click();
            firstName.FillIn(account.AccountName);
            lastName.FillIn(account.AccountLastName);
            phone.FillIn(account.Phone);
            salutationDropdown.Select(account.salutationContact);
            accountNameDropdown.SelectForContact();
            saveNewContact.Click();
            return this;
        }

    }
}

