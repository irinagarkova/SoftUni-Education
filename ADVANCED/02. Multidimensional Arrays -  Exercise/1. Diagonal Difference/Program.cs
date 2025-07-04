namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] board = new int[n, n];

            for (int row = 0; row < board.GetLength(0); row++) // броя на редовете
            {
                 int[] input = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();
                for (int cols = 0; cols < board.GetLength(1); cols++) // броя на колоните
                {
                    board[row, cols] = input[cols];//от борда на дадения ред и колона да взема от инпут неговата ст.
                }

            }
                int leftSum = 0;
                // от ляво на дясно 
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    leftSum += board[row, row];
                }

                //от дясно на ляво
                int rightSum = 0;
                int colDiagonal = board.GetLength(1) - 1;
                for (int roww = 0; roww < board.GetLength(0); roww++)
                {
                    rightSum += board[roww, colDiagonal--];
                }
                Console.WriteLine(Math.Abs(leftSum-rightSum));

        }
    }
}
