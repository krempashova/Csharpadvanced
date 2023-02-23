using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _07._Parking_LotLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> cars = new HashSet<string>();
            string comand;
            while ((comand=Console.ReadLine())!="END")
            {
                string[] tokens = comand.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                string carNUM = tokens[1];
                switch (direction)
                {
                    case "IN":
                        cars.Add(carNUM);


                        break;
                    case "OUT":
                        cars.Remove(carNUM);
                        break;
                }

                

            }
            if (cars.Count > 0)

            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }


        }
    }
}
