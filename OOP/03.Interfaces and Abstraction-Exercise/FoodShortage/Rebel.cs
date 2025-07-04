using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    internal class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; }
        public int Age { get; }
        public string Group { get; }
        public int Food { get; private set; }

        public void BuyFood() => Food += 5;
       
    }
}
