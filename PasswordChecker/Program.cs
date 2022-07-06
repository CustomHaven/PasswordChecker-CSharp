// https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-password-checker
using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Q1 
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVXYZ"; ;
            string lowercase = "abcdefghijklmnopqrstuvxyz";
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*-+";

            // Q2
            Console.Write("Enter a Password. ");
            string password = Console.ReadLine();
            Console.WriteLine(password);
            // Q3
            int score = 0;

            // All these if statements: Q4 - Q9
            if (password.Length >= minLength)
            {
                score++;
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            if (Tools.Contains(password, lowercase))
            {
                score++;
            }

            if (Tools.Contains(password, digits))
            {
                score++;
            }

            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            if (password == "password" || password == "1234")
            {
                score = 0;
            }

            Console.WriteLine(score);


            // Q10 - Q11
            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("Password extremely strong!");
                    break;
                case 3:
                    Console.WriteLine("Password strong!");
                    break;
                case 2:
                    Console.WriteLine("Password is medium!");
                    break;
                case 1:
                    Console.WriteLine("Password is weak!");
                    break;
                default:
                    Console.WriteLine("Password doesn’t meet any of the standards");
                    break;
            }

            /*
             * If you’re familiar with regular expressions, use them instead of Tools.Contains().
             */

        }
    }
}
