namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstHand.Count > 0 && secondHand.Count > 0)
            {
                int playerOneCard = firstHand[0];
                int playerTwoCard = secondHand[0];

                if (playerOneCard > playerTwoCard)
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                    firstHand.Add(playerTwoCard);
                    firstHand.Add(playerOneCard);
                }
                else if (playerTwoCard > playerOneCard)
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                    secondHand.Add(playerOneCard);
                    secondHand.Add(playerTwoCard);
                }
                else
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
            }

            if (firstHand.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {Sum(firstHand)}");
            }
            else if (secondHand.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {Sum(secondHand)}");
            }
            else
            {
                Console.WriteLine("No player wins! Sum: 0");
            }
        }

        private static int Sum(List<int> list)
        {
            int sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }

            return sum;
        }
    }
}