using System;
using System.Collections.Generic;
using System.Linq;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
            throw new NotImplementedException();
        }

        public static String GenerateInitials(String firstName, String lastName)
        {
            return char.ToUpper(firstName[0]) + "." + char.ToUpper(lastName[0]);
            throw new NotImplementedException();
        }

        public static double AddVat(double originalPrice, double vatRate)
        {
            return Math.Round(((originalPrice * vatRate) / 100) + originalPrice, 2);
            throw new NotImplementedException();
        }

        public static String Reverse(String sentence)
        {
            return string.Join(" ", sentence.Split(' ').Reverse().Select(x => new String(x.Reverse().ToArray())));
            throw new NotImplementedException();
        }

        public static int CountLinuxUsers(List<User> users)
        {
            return users.Count(x => x.Type == "Linux");
            throw new NotImplementedException();
        }
        public static void Main()
        {
            string CapitalWord = Exercise001.CapitalizeWord("hello");
            Console.WriteLine(CapitalWord);

            string intials = Exercise001.GenerateInitials("Frederic", "Bonneville");
            Console.WriteLine(intials);

            double vat = Exercise001.AddVat(25, 0);
            Console.WriteLine(vat);

            string reverse = Exercise001.Reverse(" why would you even want to do this?");
            Console.WriteLine(reverse);

            User u1 = new User("Heather", "Windows 10", "Windows");
            User u2 = new User("Paul", "Windows 95", "Windows");
            User u3 = new User("Sheila", "CentOS 7", "Linux");
            User u4 = new User("Pedro", "Ubuntu 18.04", "Linux");

            var users = new List<User>();
            users.Add(u1);
            users.Add(u2);
            Console.WriteLine(Exercise001.CountLinuxUsers(users));

            /*var users = new List<User>();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            Console.WriteLine(Exercise001.CountLinuxUsers(users));*/
            Person p1 = new Person("Peter", "Smith", "Manchester", 23);
            Person p2 = new Person("Susan", "Farmer", "Leeds", 23);
            Console.WriteLine(Exercise002.IsFromManchester(p1));
            Console.WriteLine(Exercise002.IsFromManchester(p2));

            Person p3 = new Person("Peter", "Smith", "Manchester", 17);
            Person p4 = new Person("Susan", "Farmer", "Leeds", 18);
            Console.WriteLine(Exercise002.CanWatchFilm(p3, 18));
            Console.WriteLine(Exercise002.CanWatchFilm(p4, 15));
        }
    }
}
