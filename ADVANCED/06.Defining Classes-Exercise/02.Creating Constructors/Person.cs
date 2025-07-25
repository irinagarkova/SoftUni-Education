﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name; //field
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int age)
            :this()
        {
            this.Age = age;
           
        }
        public Person(string name, int age)
            :this(age)
        {
            this.Name = name;
          
        }
       
        public string Name //пропърти
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
