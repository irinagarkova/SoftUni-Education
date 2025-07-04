using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals.Birds
{
    public class Owl : BaseBird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double GrowthFactor =>
            0.25;

        public override string AskForFood() => "Hoot Hoot";
        public override bool EatFood(IFood food)
     => food is Meat && base.EatFood(food);
    }
}
