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
        Dropdown actionDropdown = new Dropdown(By.XPath("//div[@class='forceVirtualActionMarker forceVirtualAction']"));
        Button newButton = new Button(By.XPath("//div[@title='New']"));
        Button saveNewContact = new Button("SaveEdit");
        Button deleteButton = new Button(By.XPath("//button[@title='Delete']"));
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

        public ContactsPage EditContact (Account account)
        {
            actionDropdown.SelectForContactAction(account.editAccount);
            firstName.UpdateValue(account.AccountName);
            lastName.UpdateValue(account.AccountNumber);
            phone.UpdateValue(account.Phone);
            saveNewContact.Click();
            return this;
        }

        public ContactsPage DeleteContact(Account account)
        {
            actionDropdown.SelectForContactAction(account.deleteAccount);
            deleteButton.Click();
            return this;
        }
    }
}

