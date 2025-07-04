using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        protected Animal(string name, int age, string gender)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Animal should not have empty name.", nameof(name));
            if (age < 0) throw new ArgumentException("Animal should not have negative age.", nameof(age));
            if (string.IsNullOrWhiteSpace(gender)) throw new ArgumentException("Animal should not have empty gender.", nameof(gender));

            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; }
        public int Age { get; }
        public string Gender { get; }

        public abstract string ProduceSound();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this.GetType().Name);
            stringBuilder.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            stringBuilder.Append(this.ProduceSound());

            return stringBuilder.ToString();
        }
    }
}
