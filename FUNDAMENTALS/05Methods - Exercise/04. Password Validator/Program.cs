﻿namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            bool lentchCheckPassed = CheckLength(pass); //дължина 
            bool symbolCheckPassed = CheckSpecialSymbols(pass); //само букви или цифри
            bool twoDigitsCheckPassed = CheckForTwoDigits(pass); // да има поне 2 цифри

            if (!lentchCheckPassed)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!symbolCheckPassed)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!twoDigitsCheckPassed)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (lentchCheckPassed && symbolCheckPassed && twoDigitsCheckPassed)
            {
                Console.WriteLine("Password is valid");
            }
        }
        private static bool CheckLength(string pass)
        {
            if (pass.Length < 6 || pass.Length > 10)
            {
                return false;
            }
            return true;
        }

        private static bool CheckSpecialSymbols(string pass)
        {
            foreach (var symbol in pass)
            {
                if (symbol >= 65 && symbol <= 90 ||
                    symbol >= 97 && symbol <= 122 ||
                    symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckForTwoDigits(string pass)
        {
            int count = 0;
            foreach (var symbol in pass)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    count++;
                }
            }

            if (count < 2)
            {
                return false;
            }
            return true;
        }
    }
}
