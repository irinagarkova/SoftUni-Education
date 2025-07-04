using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_4._Validate_Data_for_the_Topping_Class
{
    public class Pizza
    {
        private const int MaxNameLength = 15;
        private const int MaxToppingsCount = 10;

        private readonly List<Topping> _toppings;

        public Pizza(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > MaxNameLength) throw new ArgumentException($"Pizza name should be between 1 and {MaxNameLength} symbols.");
            this.Name = name;

            this._toppings = new List<Topping>();
            this.Toppings = this._toppings.AsReadOnly();
        }

        public string Name { get; }
        public Dough Dough { get; set; }
        public IReadOnlyCollection<Topping> Toppings { get; }
        public int ToppingsCount => this._toppings.Count;
        public double TotalCalories => this.Dough.CalculateCalories() + this._toppings.Sum(t => t.CalculateCalories());

        public void AddTopping(Topping topping)
        {
            if (this._toppings.Count == MaxToppingsCount) throw new InvalidOperationException($"Number of toppings should be in range [0..{MaxToppingsCount}].");
            this._toppings.Add(topping);
        }

        public override string ToString() => $"{this.Name} - {this.TotalCalories:f2} Calories.";
    }
}
