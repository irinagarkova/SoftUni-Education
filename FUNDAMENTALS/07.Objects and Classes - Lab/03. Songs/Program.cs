namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> playList = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] songTokens = Console.ReadLine().Split("_");
                Song song = new Song();
                song.TypeList = songTokens[0];
                song.Name = songTokens[1];
                song.Time = songTokens[2];

                playList.Add(song);
            }
            string playListToPrint = Console.ReadLine();
            if (playListToPrint == "all")
            {
                foreach (var song in playList)
                {
                    Console.WriteLine(song.Name);
                }
                return;
            }
            foreach (Song song in playList)
            {
                if (song.TypeList == playListToPrint)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
    class Song 
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    
    }
}
