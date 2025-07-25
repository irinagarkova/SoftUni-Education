﻿using _01._Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : BaseVehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double ConsumptionIncrease => 1.6;

        public override bool Refuel(double liters) => base.Refuel(liters * 0.95);
    }
}
