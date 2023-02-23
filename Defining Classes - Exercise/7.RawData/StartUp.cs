using System;
using System.Runtime.CompilerServices;
using RawData;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                     string[] carprop = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4

                 Car car = new(carprop[0], int.Parse(carprop[1]), int.Parse(carprop[2]),int.Parse(carprop[3]),
                  carprop[4],double.Parse(carprop[5]),int.Parse(carprop[6]),
                  double.Parse(carprop[7]), int.Parse(carprop[8]),
                  double.Parse(carprop[9]), int.Parse(carprop[10]),
                  double.Parse(carprop[11]), int.Parse(carprop[12]));

                     cars.Add(car);
            }

            string action = Console.ReadLine();
            string[] filtercars;
            if(action=="fragile")
            {
                filtercars = cars.Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t =>t.Pressure < 1))
                     .Select(c => c.Model)
                     .ToArray();

            }
            else
            {
                filtercars = cars.Where(c => c.Cargo.CargoType == "flammable" && c.Engine.HorsePower > 250)
                    .Select(c => c.Model)
                    .ToArray();
            }
            Console.WriteLine(string.Join(Environment.NewLine,filtercars));
        }


    }
}
