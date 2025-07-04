namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputSong = Console.ReadLine()
                .Split(", ");

            Queue<string> songs = new Queue<string>(inputSong);

            while (true)
            {
                string[] commandInfo = Console.ReadLine().Split();
                if (commandInfo[0] == "Play")
                {
                    songs.Dequeue();
                    if (songs.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (commandInfo[0] == "Add")
                {
                    //SKIP ще премахне командата 
                    //ПРИМЕРНО:
                    //["Add", "Watch", "Me"].Skip(1)
                    //ще стане 
                    // "Watch Me"
                    string songName = string.Join(" ", commandInfo.Skip(1));

                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songName);
                    }
                }
                else if (commandInfo[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
            }
        }
    }
}
