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

            Tire[] tires = new Tire[4]
            {
                new Tire(1,2.5),
                new Tire(1,2.1),
                new Tire(2,0.5),
                new Tire(2,2.3),
            };
            Engine engine=new Engine(560,300);
            Car car = new Car("Ferrari", "blabla", 2022, 250, 9, engine, tires);
        }
    }
}