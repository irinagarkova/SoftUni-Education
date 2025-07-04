using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Shopping_Spree
{
    public interface IIngredient
    {
        const double BaseWeightModifier = 2;

        double Weight { get; }
        double CalculateCalories();
    }
}
