using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Interfaces;

namespace WildFarm.Animals
{
    public abstract class BaseAnimal : IAnimal
    {
        public BaseAnimal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        
        protected abstract double GrowthFactor { get; }

        public abstract string AskForFood();

        public virtual bool EatFood(IFood food)
        {
            this.Weight += food.Quantity * this.GrowthFactor;
            this.FoodEaten = food.Quantity;
            return true;

        }
    }
}
