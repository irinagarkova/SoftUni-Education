using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals.Mammal.Felines
{
    public class Cat : BaseFeline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        protected override double GrowthFactor => 0.3;

        public override string AskForFood() => "Meow";
        public override bool EatFood(IFood food)
         => food is Vegetable or Meat && base.EatFood(food);
    }
}
