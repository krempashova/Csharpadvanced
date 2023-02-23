using System;
using DefiningClasses;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new();
            peter.Name = "Peter";
            peter.Age = 20;

            Person george = new();

            george.Name = "George";
            george.Age = 18;



            Person jose = new();
            jose.Name = "Jose";
            jose.Age = 43;

            Person noNameDefaultage= new();
            Person noNameAge = new(25);
            Person nameandAge = new("Jonh", 45);

             
            Console.WriteLine($"{peter.Name} is {peter.Age} years old");
            Console.WriteLine($"{george.Name} is {george.Age} years old");
            Console.WriteLine($"{jose.Name} is {jose.Age} years old");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{noNameDefaultage.Name} is {noNameDefaultage.Age} years old");
            Console.WriteLine($"{noNameAge.Name} is {noNameAge.Age} years old");
            Console.WriteLine($"{nameandAge.Name} is {nameandAge.Age} years old");
        }


    }
}
