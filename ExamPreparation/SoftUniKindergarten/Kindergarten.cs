using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using SoftUniKindergarten;
using System.Text;
using System;
using System.Security.Cryptography.X509Certificates;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        readonly List<Child> registry = new List<Child>();
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry= new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }


        public bool AddChild(Child child)
        {
            if(Registry.Count<Capacity)
            {
                Registry.Add(child);
             
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool RemoveChild(string childFullName)
        {
            var names = childFullName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var child = this.Registry.FirstOrDefault(x => x.FirstName == names[0] && x.LastName == names[1]);
            return this.Registry.Remove(child);
        }



       public   Child GetChild(string childFullName)
        {
            var names = childFullName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return this.Registry.FirstOrDefault(x => x.FirstName == names[0] && x.LastName == names[1]);
        }






        public int ChildrenCount { get { return Registry.Count; } }

       
        

        public string RegistryReport()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Registered children in {Name}:");
           

            foreach (var child in Registry.OrderByDescending(x => x.Age).ThenBy(x => x.LastName).ThenBy(x => x.FirstName));
            {
                sb.AppendLine(child.ToString());

            } 
            
            return sb.ToString().Trim();
        }

    }
}
