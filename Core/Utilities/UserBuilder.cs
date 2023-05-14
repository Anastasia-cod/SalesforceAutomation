using System;
using Bogus;
using Core.Models;
using NUnit.Framework;

namespace Core.Utilities
{
    public static class UserBuilder
    {
        static Faker Faker = new Faker();

        public static User StandartUser => new User
        {
            Name = TestContext.Parameters.Get("UserName"),
            Password = TestContext.Parameters.Get("UserPassword"),
        };

        public static User UserWithoutPassword => new User
        {
            Name = TestContext.Parameters.Get("UserName"),
            Password = "",
        };

        public static User GetRandomUser() => new()
        {
            Name = Faker.Internet.Email(provider: "QA_Test.13May"),
            Password = Faker.Internet.Password(12),
        };

        public static User GetRandomUser(string email) => new()
        {
            Name = email,
            Password = Faker.Internet.Password(13),
        };
    }
}

