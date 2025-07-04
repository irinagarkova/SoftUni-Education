namespace _06._Equal_Sum
{
    internal class Program
    {
            static int FindBalanceIndex(int[] arr)
            {
                int totalSum = 0;
                foreach (int num in arr)
                {
                    totalSum += num;
                }

                int leftSum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    int rightSum = totalSum - leftSum - arr[i];
                    if (leftSum == rightSum)
                    {
                        return i;
                    }
                    leftSum += arr[i];
                }

                return -1; 
            }

            static void Main()
            {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int balanceIndex = FindBalanceIndex(arr);

                if (balanceIndex != -1)
                {
                    Console.WriteLine($"{balanceIndex}");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
