namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int lastSlashIndex = path.LastIndexOf('\\');
            string fullFileName = path.Substring(lastSlashIndex + 1);

            int lastDotIndex = fullFileName.IndexOf('.');
            string name = fullFileName.Substring(0, lastDotIndex);
            string extension = fullFileName.Substring(lastDotIndex + 1);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
