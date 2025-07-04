namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] board = new char[rows, cols];

            for (int row = 0; row < board.GetLength(0); row++) 
            {
                string[] input = Console.ReadLine()
               .Split(' ');

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = input[col][0]; //["A"][0] -> 'A'
                }
            }
            int euqualSquares = 0;
            for (int row = 0; row < board.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < board.GetLength(1) - 1; col++)
                {
                    bool areEqual =
                        board[row, col] == board[row + 1, col]
                        && board[row, col + 1] == board[row + 1, col + 1]
                        && board[row, col] == board[row + 1, col + 1];

                    if (areEqual)
                    {
                        euqualSquares++;
                    }
                }
            }
            Console.WriteLine(euqualSquares);
        }
    }
}
