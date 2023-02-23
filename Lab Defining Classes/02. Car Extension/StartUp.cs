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

            car.Make = "Mercedes";
            car.Model = "S320";
            car.Year = 2006;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(0.5);

            Console.WriteLine(car.WhoAmI());
        }
    }

}     

    
