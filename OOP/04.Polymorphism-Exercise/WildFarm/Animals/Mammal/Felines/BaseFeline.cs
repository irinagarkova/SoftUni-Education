using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals.Mammal.Felines
{
    public abstract class BaseFeline : BaseMammal
    {
        protected BaseFeline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
           this. Breed = breed;
        }
         public string Breed { get; }
        public override string ToString()
            => $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }

    
}
