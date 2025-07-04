using Microsoft.VisualBasic;

namespace _03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfCards = Console.ReadLine()
             .Split(", ")
             .ToList();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split(", ");
                string index = command[0];
                string card = command[1];

                if (index == "Add")
                {
                    if (listOfCards.Contains(card))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        //добави
                        listOfCards.Add(card);
                        Console.WriteLine("Card successfully added");
                    }

                }

                else if (index == "Remove")
                {
                    if (listOfCards.Contains(card))
                    {
                        //махни 
                        listOfCards.Remove(card);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }

                }
                else if (index == "Remove At")
                {
                    int notOfRange = int.Parse(card);

                    if (notOfRange >= 0 && notOfRange < listOfCards.Count)
                    {
                        //премахни
                        listOfCards.RemoveAt(notOfRange);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (index == "Insert")
                {
                    int indexNotOfRange = int.Parse(command[1]);
                    card = command[2];
                    if (indexNotOfRange >= 0 && indexNotOfRange <= listOfCards.Count)
                    {
                        if (listOfCards.Contains(card))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            listOfCards.Insert(indexNotOfRange, card);
                            Console.WriteLine("Card successfully added");
                        }
                    }
                    else
                    {
                       Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ",listOfCards));
        }
    }
}
