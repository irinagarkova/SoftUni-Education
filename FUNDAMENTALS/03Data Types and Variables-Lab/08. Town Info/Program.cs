﻿namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
           ushort area = ushort.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {area} square km.");
        }
    }
}
