namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = dimensions[0];
            int col = dimensions[1];

            int[,] matrix = new int[row, col]; //матрица с толкова реда и толкова колони

            for (int rows = 0; rows < matrix.GetLength(0); rows++) // getLength(1) са редовете(първо измерение)
            { // четене на матрицата

                int[] values = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++) // getLength(1) са колоните (второ измерение)
                {
                    matrix[rows, cols] = values[cols];
                }
            }
            int sum = 0;

            foreach (var value in matrix)
            {
                sum += value;
            }
            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(sum);

        }
    }
}
