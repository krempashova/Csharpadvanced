﻿using System;
using RawData;

namespace RawData
{
    public class Cargo
    {

        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get; set; }

        public string  CargoType { get; set; }
    }
}
