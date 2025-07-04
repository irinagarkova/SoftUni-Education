using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;


        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"{nameof(Name)} cannot be empty.");

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < MinAge || value> MaxAge)
                    throw new ArgumentException($"{nameof(Age)} should be between {MinAge} and {MaxAge}.");

                this.age = value;
            }
        }

        public double ProductPerDay => this.CalculateProductPerDay();
       
        private double CalculateProductPerDay()
        {
            return this.Age switch
            {
                0 or 1 or 2 or 3 => 1.5,
                4 or 5 or 6 or 7 => 2,
                8 or 9 or 10 or 11 => 1,
                _ => 0.75,
            };
        }
    }
}
