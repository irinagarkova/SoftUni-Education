namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //command
            List<int> list = Console.ReadLine()
           .Split(' ')
           .Select(int.Parse)
            .ToList();

            //opperations
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] argss = command.Split();

                switch (argss[0])
                {
                    case"Delete":
                        int element = int.Parse(argss[1]);
                            list.RemoveAll(el => el == element); //ЛАНДА ФУНКЦИЯ/ Ако el е РАВНО на element, махни всички/
                            break;
                    case"Insert":
                            element = int.Parse(argss[1]);
                        int position = int.Parse(argss[2]);
                        list.Insert(position, element);
                        break;
                }
            }
            //output
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
