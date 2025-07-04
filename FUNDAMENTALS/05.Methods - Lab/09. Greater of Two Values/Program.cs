namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondtValue = Console.ReadLine();

            if (type == "string")
            {
                GetMax(firstValue, secondtValue);
            }

            else if (type == "char")
            {
                GetMax(char.Parse(firstValue), char.Parse(secondtValue));
            }
            else
            {
                GetMax(int.Parse(firstValue), int.Parse(secondtValue));
            }
        }
        static void GetMax(int a, int b)
        {
            Console.WriteLine(a <b ? b : a); 
            //Тернарен операто !! 
            // АКО(IF) A < B изпечатай Б в противен случай(еlse) изпечатай А 
        }
        static void GetMax(char a, char b)
        {
            Console.WriteLine(a < b ? b : a);
        }
        static void GetMax(string a, string b)
        {
           
            int result = a.CompareTo(b);
            if (result > 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
