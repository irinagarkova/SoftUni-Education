using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals.Mammal
{
    public class Mouse : BaseMammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }
        protected override double GrowthFactor => 0.1;

        public override string AskForFood() => "Squeak";

        public override bool EatFood(IFood food) 
            => food is Vegetable or Fruit && base.EatFood(food);
      

    }
}
