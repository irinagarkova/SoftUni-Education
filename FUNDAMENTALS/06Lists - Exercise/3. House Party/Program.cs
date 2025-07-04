using System.Threading.Channels;
using System.Xml.Linq;

namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            4
            Allie is going!
            George is going!
            John is not going!
            George is not going!
            */
            int count = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string[] argss = Console.ReadLine()
                        .Split();
                // ако имаме 
                if (argss[2] == "going!")
                {
                    string name = argss[0];
                    int index = guestList.IndexOf(name); // проверяваме дали съществува дадения човек в ЛИСТА
                    if (index != -1) // ако индекс е различно от -1, значи дадения човек същестува 
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else // ако не същестува ще го добавим 
                    {
                        guestList.Add(name);
                    }
                }
                else if (argss[2] == "not")
                {
                    string name = argss[0];
                    int index = guestList.IndexOf(name);  //ако примерно guestList е 10ел. то значи може да от 0 до 9 индекса

                    if (index != -1) //ако е различно от -1
                    {
                        guestList.RemoveAt(index);
                    }
                    else 
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]) ;
            }
        }
    }
}
