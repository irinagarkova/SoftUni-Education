﻿namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> state = new Stack<string>();

            int n = int.Parse(Console.ReadLine());
            string text = string.Empty; //StringBuilder

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    state.Push(text);
                    text += command[1];
                }
                else if (command[0] == "2")
                {
                    state.Push(text);
                    int valueToErase = int.Parse(command[1]);
                    text = text.Substring(0, text.Length - 3); // с махаме колкото символа искаме ( -3 примерно)
                }
                else if (command[0] == "3")
                {
                    int indexToPrint = int.Parse(command[1]);
                    Console.WriteLine(text[indexToPrint - 1]);
                }
                else if (command[0] == "4")
                {
                    text = state.Pop();
                }
            }
        }
    }
}
