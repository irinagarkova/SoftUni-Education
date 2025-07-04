namespace _10_RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadSet = 0;
            int trashedMouse = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadSet++;
                }
                if (i % 3 == 0)
                {
                    //cupi mishka
                    trashedMouse++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboard++;

                    if (trashedKeyboard % 2 == 0)
                    {
                      trashedDisplay++;
                    }
                }
            }
            double totalHeadSet = trashedHeadSet * headSetPrice;
            double totalMouse = trashedMouse * mousePrice;
            double totalKeyboard = trashedKeyboard * keyboardPrice;
            double exprenses = totalHeadSet + totalMouse + totalKeyboard;

            Console.WriteLine($"Rage expenses: {exprenses:F2} lv.");
        }
    }
}
