using System.Linq;
using System.Xml;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputNames = Console.ReadLine().Split();
            Action<string[]> printNames = names
                => Console.WriteLine(string.Join(Environment.NewLine, names
                .Select(name => "Sir " + name)));// като пред всеки един от елементите принтираш Сър

                printNames(inputNames);
        }
    }
}
