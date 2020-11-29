using Xunit;
using TechReturners.Exercises;
using System.Collections.Generic;


namespace TechReturners.Tests
{
    public class Exercise001Test
    {
        [Fact]
        public void CheckCapitalizeWord()
        {
            Assert.Equal("Hello", Exercise001.CapitalizeWord("hello"));
            Assert.Equal("Oh no, bears!!", Exercise001.CapitalizeWord("oh no, bears!!"));
            Assert.Equal("The quick fox", Exercise001.CapitalizeWord("the quick fox"));
        }

        [Fact]
        public void CheckHelloAlreadyUppercase()
        {
            Assert.Equal("Hello", Exercise001.CapitalizeWord("Hello"));
        }

        [Fact]
        public void CheckGenerateInitials()
        {
            Assert.Equal("F.B", Exercise001.GenerateInitials("Frederic", "Bonneville"));
            Assert.Equal("J.B", Exercise001.GenerateInitials("James", "Bond"));
        }

        [Fact]
        public void CheckAddVat()
        {
            Assert.Equal(120, Exercise001.AddVat(100, 20));
            Assert.Equal(47, Exercise001.AddVat(40, 17.5));
            Assert.Equal(39.36, Exercise001.AddVat(33.5, 17.5));
            Assert.Equal(25, Exercise001.AddVat(25, 0));
        }

        [Fact]
        public void CheckReverse()
        {
            Assert.Equal("oof", Exercise001.Reverse("foo"));
            Assert.Equal("?siht od ot tnaw neve uoy dluow yhw", Exercise001.Reverse("why would you even want to do this?"));
        }

        [Fact]
        public void CheckCountLinuxUsers()
        {
            User u1 = new User("Heather", "Windows 10", "Windows");
            User u2 = new User("Paul", "Windows 95", "Windows");
            User u3 = new User("Sheila", "CentOS 7", "Linux");
            User u4 = new User("Pedro", "Ubuntu 18.04", "Linux");

            var users = new List<User>();
            users.Add(u1);
            users.Add(u2);
            Assert.Equal(0, Exercise001.CountLinuxUsers(users));

            users = new List<User>();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            Assert.Equal(2, Exercise001.CountLinuxUsers(users));
        }
    }
}
