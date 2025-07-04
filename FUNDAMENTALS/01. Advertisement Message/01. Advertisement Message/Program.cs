using System;
using System.Numerics;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        class FakeMessanges
        {
            public readonly string[]  Phases =
            {
                "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can't live without this product."
            };

            public readonly string[] Events =
            {
                 "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles.I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"

            };

            public readonly string[] Authors =
            {
                  "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };


            public readonly string[] Cities =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
            public string RandomMess()
            {
                Random text = new Random();

                int index = text.Next(Phases.Length);
                string phrase = Phases[index];

                index = text.Next(Events.Length);
                string @event = Events[index];

                index = text.Next(Authors.Length);
                string author = Authors[index];

                index = text.Next(Cities.Length);
                string city = Cities[index];


                return $"{phrase} {@event} {author} – {city}.";
            }
        }
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers; i++)
            {
                FakeMessanges fake = new FakeMessanges();
                Console.WriteLine(fake.RandomMess());
            }
        }
    }
}
