namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++) // getLength(1) са редовете(първо измерение)
            { // четене на матрицата

                int[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++) // getLength(1) са колоните (второ измерение)
                {
                    matrix[rows, cols] = values[cols];
                }
            }

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            { // четене на матрицата
                int sum = 0;
                //за да въртя колоните а не редовете ! 
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    sum += matrix[rows, cols];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
