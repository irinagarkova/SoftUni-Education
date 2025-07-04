using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals.Mammal
{
    public  class Dog : BaseMammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        protected override double GrowthFactor => 0.4;

        public override string AskForFood() => "Woof!";

        public override bool EatFood(IFood food)
     => food is Meat && base.EatFood(food);
    }
}
