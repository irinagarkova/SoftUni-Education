﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Irina",
                Age = 24
            };

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
