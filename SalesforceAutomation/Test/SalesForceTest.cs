using NUnit.Framework;
using Core.Selenium;
using System;
using Core.Utilities;
using Core.Models;

namespace SalesforceAutomation.Test
{
	public class SalesForceTest : BaseTest
	{
		[Test]
		public void Test()
		{
			//var
            var standartUser = UserBuilder.StandartUser;

			//Action
            LoginPage
				.OpenPage()
				.Login(standartUser);

			//Assert
		}
	}
}

