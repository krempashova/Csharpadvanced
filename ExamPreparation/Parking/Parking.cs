using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Parking;

namespace Parking
{
    public class Parking
    {

        private List<Car> car;

        public Parking(string type, int capacity)
        {
            Type=type;
            Capacity=capacity;
            Car = new List<Car>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Car> Car { get; set; }

        public void Add(Car car)
        {
            if(Car.Count< Capacity)
            {
                Car.Add(car);
            }
        }
         public  bool Remove(string manufacturer, string model)
        {

            for (int i = 0; i < Car.Count; i++)
            {
                if (Car[i].Manufacturer== manufacturer && Car[i].Model==model)
                {
                    Car.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
         public Car GetLatestCar()=>Car.Where(c=>c.Year>0).FirstOrDefault();

        // {
        //if(Car.Count==0)
        //{
        //    return null;
        //}
        //else
        //{
        //   Car carlatestCar = Car[0];
        //    foreach (var car in Car)
        //    {
        //        if(car.Year>carlatestCar.Year)
        //        {
        //            carlatestCar = car;
        //        }
        //    }
        //    return carlatestCar;
        //}
        //}

        public Car GetCar(string manufacturer, string model) =>
           Car.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model==model);
        public int Count { get { return Car.Count; } }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var item in Car)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}