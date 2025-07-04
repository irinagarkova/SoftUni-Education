namespace _10._Multiply_Evens_by_Odds
{
    internal class Program

    { 
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumOfEven = GetSumOfEvenDigits(number);
            int sumOfOdd = GetSumOfOddDigits(number);
            return sumOfEven * sumOfOdd;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                    sum += digit;
                number /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                    sum += digit;
                number /= 10;
            }
            return sum;
        }
    }

}

