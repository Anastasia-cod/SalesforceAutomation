using System;
using Bogus;
using Core.Models;
using NUnit.Framework;

namespace Core.Utilities
{
    public class AccountBuilder
    {
        static Faker Faker = new Faker();

        public static Account GetRandomAccount() => new()
        {
            AccountName = Faker.Internet.UserName(),
            AccountNumber = Faker.Random.Int(3).ToString(),
            AccountSite = Faker.Internet.Url(),
            Phone = Faker.Random.Int(9).ToString(),
            Website = Faker.Internet.Url(),
            OwnerShip = "Public",
            Type = "Prospect",
            BillingStreet = Faker.Address.StreetAddress(),
        };
    }
}

