using System;
using SpeedRacing;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> allcars = new();

            int countcars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countcars; i++)
            {
                
                   string[] infocars = Console.ReadLine()//AudiA4 23 0.3
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new()
                {
                    Model = infocars[0],
                    FuelAmount =  double.Parse(infocars[1]),
                    FuelConsumptionPerKilometer = double.Parse(infocars[2])

                };
                allcars.Add(car.Model,car);
            }

            string comand = string.Empty;

            while ((comand=Console.ReadLine())!="End")
            {
                string []driveinfo = comand
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int distanceinkm = int.Parse(driveinfo[2]);
                string model = driveinfo[1];

                Car car = allcars[model];

                car.Drive(distanceinkm);

            }

            foreach (var car in allcars.Values)
            {

                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Travelleddistance}");
            }
        }


    }
}
