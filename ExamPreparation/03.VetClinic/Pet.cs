using System;
using System.Collections.Generic;
using System.Text;
using VetClinic;

namespace VetClinic
{
    public class Pet
    {
        public Pet(string name, int age, string owner)
        {
            Name = name;
            Age = age;
            Owner = owner;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name} Age: {Age} Owner: {Owner}");
            return sb.ToString().Trim();
        }
    }
}
