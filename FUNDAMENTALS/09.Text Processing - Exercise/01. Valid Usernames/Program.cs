﻿namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(", ");

            for (int i = 0; i < text.Length; i++)
            {
                if (IsValidUserName(text[i]))
                {
                    Console.WriteLine(text[i]);
                }
            }

        }
        static bool IsValidUserName(string username)
        {
            if (username.Length >= 3 && username.Length <= 16)
            {
                for (int i = 0; i < username.Length; i++)
                {
                    if (!char.IsLetter(username[i]) && !char.IsDigit(username[i]) && username[i] != '-' && username[i] != '_')
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
