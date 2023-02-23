using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "BMW";
            car.Model = "X5";
            car.Year = 2006;

            Console.WriteLine($"My car is {car.Make} {car.Model} - {car.Year} year.");
        }
    }


}

