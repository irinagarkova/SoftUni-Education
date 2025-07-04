using System.Numerics;
using System.Threading.Channels;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldLength = int.Parse(Console.ReadLine());

            int[] field = new int[fieldLength];

            int[] bugPlaces = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //пълним масива с ФОР цъкъл
            for (int i = 0; i < bugPlaces.Length; i++)
            {
                int currentIndex = bugPlaces[i];
                if(currentIndex >=0 && currentIndex <fieldLength) // дали дадения интекс е в диапазона на масива
                {
                    field[currentIndex] = 1;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(" "); // разделя елементите
                int bugIndex = int.Parse(arguments[0]); // търсим калинките
                string direction = arguments[1]; // посоката на която ще се движим
                int flyLength = int.Parse(arguments[2]); // с колко ще подскача калинката

                //проверяваме дали позицията е валидна ТОЕСТ дали имаме калинка на даденото поле
                if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)// дали е в границите на масива или е отвън 
                {
                    continue;
                }
                field[bugIndex] = 0; // щом магнем калинката индекса трябва да остане 0
                
                if (direction == "right")
                {
                    int landIndex = bugIndex + flyLength; //където ще кацне калинката
                    if (landIndex > field.Length - 1) // дали калинката е излезнала от масива 
                    {
                        continue;
                    }

                    if (field[landIndex] == 1) //проверяваме дали има калинка на дадената позиция
                    {
                        while (field[landIndex] == 1) // въртим докато ИМА калинка 
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break; 
                            }
                        }
                    }
                    if (landIndex <= field.Length - 1) //ако сме още в масива слагаме 1 // 1 = калинка
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = bugIndex - flyLength; //където ще кацне калинката // с - намаляваме
                    if (landIndex < 0 ) // дали калинката е излезнала от масива 
                    {
                        continue;
                    }

                    if (field[landIndex] == 1) //проверяваме дали има калинка на дадената позиция
                    {
                        while (field[landIndex] == 1) // въртим докато ИМА калинка 
                        {
                            landIndex -= flyLength; // намаляваме
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0) 
                    {
                        field[landIndex] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
