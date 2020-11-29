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
        }

        public static String GenerateInitials(String firstName, String lastName)
        {
            return char.ToUpper(firstName[0]) + "." + char.ToUpper(lastName[0]);
            
        }

        public static double AddVat(double originalPrice, double vatRate)
        {
            return Math.Round(((originalPrice * vatRate) / 100) + originalPrice, 2);
            
        }

        public static String Reverse(String sentence)
        {
            return string.Join(" ", sentence.Split(' ').Reverse().Select(x => new String(x.Reverse().ToArray())));
            
        }

        public static int CountLinuxUsers(List<User> users)
        {
            return users.Count(x => x.Type == "Linux");
            
        }
        
    }
}
