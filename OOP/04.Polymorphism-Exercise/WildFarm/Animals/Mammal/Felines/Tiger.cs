using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals.Mammal.Felines
{
    public class Tiger : BaseFeline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        protected override double GrowthFactor => 1;

        public override string AskForFood() => "ROAR!!!";
        public override bool EatFood(IFood food)
       => food is Meat && base.EatFood(food);
    }
}
