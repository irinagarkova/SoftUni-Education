﻿namespace Step_4._Validate_Data_for_the_Topping_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pizza pizza = null;

                var input = Console.ReadLine();
                while (input != "END")
                {
                    var data = input.Split(' ');

                    if (data[0] == "Pizza") pizza = new Pizza(data[1]);
                    else if (data[0] == "Dough") pizza.Dough = new Dough(data[1], data[2], double.Parse(data[3]));
                    else if (data[0] == "Topping") pizza.AddTopping(new Topping(data[1], double.Parse(data[2])));

                    input = Console.ReadLine();
                }

                Console.WriteLine(pizza);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
