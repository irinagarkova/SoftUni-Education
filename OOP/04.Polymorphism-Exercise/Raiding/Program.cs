using Raiding.Factories;
using Raiding.Interface;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IHeroFactory> factories = GetFactories();

            List<IHero> heroes = new List<IHero>();

            int n = int.Parse(Console.ReadLine());
            while (heroes.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (factories.TryGetValue(type, out var factory))
                    heroes.Add(factory.Create(name));

                else Console.WriteLine("Invalid hero!");
            }

            int bossPower = int.Parse(Console.ReadLine());
            int raidPower = 0;

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                raidPower += hero.Power;
            }

            if (raidPower >= bossPower) Console.WriteLine("Victory!");
            else Console.WriteLine("Defeat...");
        }

        private static Dictionary<string, IHeroFactory> GetFactories()
        {
            return new Dictionary<string, IHeroFactory>
            {
                ["Druid"] = new DruidFactory(),
                ["Paladin"] = new PaladinFactory(),
                ["Rogue"] = new RogueFactory(),
                ["Warrior"] = new WarriorFactory()
            };
        }
    }
}
