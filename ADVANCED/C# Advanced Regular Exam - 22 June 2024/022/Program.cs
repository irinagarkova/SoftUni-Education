using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] field = new char[n, n];
        int beeRow = 0, beeCol = 0;
        int totalNectar = 0;
        int energy = 15;
        bool energyRestored = false;

        // Read the matrix and find the initial position of the bee
        for (int i = 0; i < n; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < n; j++)
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
            // Clear the bee's previous position
            field[beeRow, beeCol] = '-';

            // Move the bee according to the command
            switch (command)
            {
                case "up": beeRow--; break;
                case "down": beeRow++; break;
                case "left": beeCol--; break;
                case "right": beeCol++; break;
            }

            // Check for wrapping around the matrix
            if (beeRow < 0) beeRow = n - 1;
            if (beeRow >= n) beeRow = 0;
            if (beeCol < 0) beeCol = n - 1;
            if (beeCol >= n) beeCol = 0;

            // Decrease energy by 1 unit for each move
            energy--;

            // Check the new position
            char currentCell = field[beeRow, beeCol];

            if (char.IsDigit(currentCell))
            {
                // Collect nectar
                totalNectar += currentCell - '0';
                field[beeRow, beeCol] = '-';
            }
            else if (currentCell == 'H')
            {
                // Reach the hive
                if (totalNectar >= 30)
                {
                    Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
                }
                else
                {
                    Console.WriteLine("Beesy did not manage to collect enough nectar.");
                }

                // Print the final state of the matrix
                field[beeRow, beeCol] = 'B';
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(field[i, j]);
                    }
                    Console.WriteLine();
                }
                return;
            }

            if (energy <= 0)
            {
                // Check if energy can be restored
                if (!energyRestored && totalNectar >= 30)
                {
                    energyRestored = true;
                    int excessNectar = totalNectar - 30;
                    energy += excessNectar;
                    totalNectar = 30;
                }
                else
                {
                    Console.WriteLine("This is the end! Beesy ran out of energy.");

                    // Print the final state of the matrix
                    field[beeRow, beeCol] = 'B';
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }

            // Update bee's position in the field
            field[beeRow, beeCol] = 'B';
        }

        // Print the final state of the matrix
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
