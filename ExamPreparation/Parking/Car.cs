﻿using System;
using System.Collections.Generic;
using System.Text;
using Parking;


namespace Parking
{
    public class Car
    {
        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Manufacturer} {Model} ({Year})");
            return sb.ToString().Trim();

        }
    }
}
