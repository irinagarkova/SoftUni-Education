namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            string input = Console.ReadLine();
            bool isBalanced = true;

            foreach (var item in input)
            {
                if (item is '(' or '[' or '{')
                {
                    stack.Push(item);
                    continue;
                }
                bool canPop = stack.TryPeek(out char currentChar);

                if (canPop &&
                    ((currentChar == '(' && item == ')') ||
                    (currentChar == '[' && item == ']') ||
                    (currentChar == '{' && item == '}')))
                // Ако canPop и едно от трите, тогава премахни

                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }

            }

                if (isBalanced)
                {
                Console.WriteLine("YES");
                }
                else if(!isBalanced)
                {
                Console.WriteLine("NO");
                }
        }
    }
}
