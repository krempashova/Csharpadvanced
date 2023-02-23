using System;
using SpeedRacing;

namespace SpeedRacing
{
    public class Car
    {
       
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double Travelleddistance { get; set; }

       
        public void Drive(int distanceinkm)
        {
            if (distanceinkm * FuelConsumptionPerKilometer>FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            else
            {
                FuelAmount -= (distanceinkm * FuelConsumptionPerKilometer);
                Travelleddistance += distanceinkm;
            }

        }

    }

}

