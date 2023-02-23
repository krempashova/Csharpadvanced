﻿using System;
using DefiningClasses;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int age)
            : this()
        {
            this.Age = age;
        }
        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
            this.Age = age;
        }



        public string Name { get; set; }
        public int Age { get; set; }


    }
}
