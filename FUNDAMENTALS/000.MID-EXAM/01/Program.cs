namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); // дни приключение
            int playersCount = int.Parse(Console.ReadLine()); //брой хора
            double groupEnergy = double.Parse(Console.ReadLine());//енергията на цялата група
            double waterForPerson = double.Parse(Console.ReadLine());//водата на човек
            double foodForPerson = double.Parse(Console.ReadLine()); //храната на човек

            //calculate
            double sumWater = days * playersCount * waterForPerson;
            double sumFood = days * playersCount * foodForPerson;
            for(int i =1; i <= days;i++)
            {
                double lossEnegry = double.Parse(Console.ReadLine());
                 groupEnergy -= lossEnegry;
                if (groupEnergy < 0)
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05; //увеличава енергията с 5% !!!
                    sumWater *= 0.7; //намалява водата с 30%
                }
                if (i % 3 == 0)
                {
                    sumFood = sumFood - (sumFood / playersCount) ; //намалява храната им 
                    groupEnergy *= 1.10; //увеличава им се енергията с 10% 
                }
            }
            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {sumFood:F2} food and {sumWater:f2} water.");
            }
        }
    }
}
