namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstElements = Console.ReadLine()
                 .Split(" ")
                 .ToArray();

            string[] secondElements = Console.ReadLine()
                .Split(" ")
                .ToArray();

            var commonElements = firstElements.Intersect(secondElements);
            for (int j = 0; j < secondElements.Length; j++)
            {
                for (int i = 0; i < firstElements.Length; i++)
                {
                    if (firstElements[i] == secondElements[j])
                    {
                        Console.Write($"{firstElements[i]} ");
                        break;
                    }
                }


            }
        }
    }
 }

