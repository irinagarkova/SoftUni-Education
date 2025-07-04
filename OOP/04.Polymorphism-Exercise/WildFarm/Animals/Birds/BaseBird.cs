using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals.Birds
{
    public abstract class BaseBird : BaseAnimal
    {
        protected BaseBird(string name, double weight,double wingSize)
            : base(name, weight)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; }

        public override string ToString() =>
          $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
       
    }
}
