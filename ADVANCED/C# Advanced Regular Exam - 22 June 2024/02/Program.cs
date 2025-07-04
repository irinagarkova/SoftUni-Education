using System.Numerics;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            int beeRow = 0;
            int beeCol = 0;
            int nectar = 0;
            int beeEnergy = 15;
            bool energyRestored = false;

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    field[i, j] = row[j];
                    if (row[j] == 'B')
                    {
                        beeRow = i;
                        beeCol = j;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != null)
            {
                field[beeRow, beeCol] = '-';
                switch (command)
                {
                    case "up": beeRow--; break;
                    case "down": beeRow++; break;
                    case "left": beeCol--; break;
                    case "right": beeCol++; break;
                }

                if (beeRow < 0)
                {
                    beeRow = size - 1;
                }
                if (beeRow >= size)
                {
                    beeRow = 0;
                }
                if (beeCol < 0)
                {
                    beeCol = size - 1;
                }
                if (beeCol >= size)
                {
                    beeCol = 0;
                }

                beeEnergy--;
                char currentCell = field[beeRow, beeCol];

                if (char.IsDigit(currentCell))
                {
                    nectar += currentCell - '0';
                    field[beeRow, beeCol] = '-';
                }
                else if (currentCell == 'H')
                {
                    if (nectar >= 30)
                    {
                        Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {beeEnergy}");
                    }
                    else
                    {
                        Console.WriteLine("Beesy did not manage to collect enough nectar.");
                    }
                    PrintField(field, beeRow, beeCol);
                    return;
                }

                if (beeEnergy <= 0) //има ли енергия?
                {
                    if (!energyRestored && nectar >= 30)
                    {
                        energyRestored = true;
                        int excessNectar = nectar - 30;
                        beeEnergy += excessNectar;
                        nectar = 30;
                    }
                    else
                    {
                        Console.WriteLine("This is the end! Beesy ran out of energy.");
                        PrintField(field, beeRow, beeCol);
                        return;
                    }
                }

                field[beeRow, beeCol] = 'B';
            }

            PrintField(field, beeRow, beeCol);
        }

        static void PrintField(char[,] field, int beeRow, int beeCol)
        {
            field[beeRow, beeCol] = 'B';
            int n = field.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

}
    

