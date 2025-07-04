namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
           
            string biggestKegModel = "";
            double biggestKegVolume = 0;


            for (int i = 0; i < kegsCount; i++)
            { 
              string kegModel = Console.ReadLine();

              float radius = float.Parse(Console.ReadLine());
              int hight = int.Parse(Console.ReadLine());

              double volume = Math.PI * (radius * radius) * hight;
                if (volume > biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKegModel = kegModel;
                }
            }
                Console.WriteLine(biggestKegModel);

        
        }
    }
}
