using System;
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


            Console.WriteLine($"{peter.Name} is {peter.Age} years old");
            Console.WriteLine($"{george.Name} is {george.Age} years old");
            Console.WriteLine($"{jose.Name} is {jose.Age} years old");
        }  
        
        
    }
}
