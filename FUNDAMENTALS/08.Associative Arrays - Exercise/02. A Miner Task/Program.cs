namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resurceMap = new Dictionary<string, uint>();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                uint quantity = uint.Parse(Console.ReadLine());
                
                if(!resurceMap.ContainsKey(resource))
                {
                    resurceMap.Add(resource, 0);
                }
                resurceMap[resource] += quantity;
            }
            foreach (KeyValuePair<string, uint> recoursePair in resurceMap)
            {

                Console.WriteLine($"{recoursePair.Key} -> {recoursePair.Value}");
            }
        }
    }
}
