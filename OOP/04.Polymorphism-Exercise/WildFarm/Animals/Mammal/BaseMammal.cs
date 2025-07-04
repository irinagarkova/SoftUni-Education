using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals.Mammal
{
    public abstract class BaseMammal : BaseAnimal
    {
        protected BaseMammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }
        public string LivingRegion { get; }

        public override string ToString() =>
          $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
