using System;
using RawData;


namespace RawData
{
    public class Engine
    {

        public Engine(int speed, int horsePower)
        {
            Speed = speed;
            HorsePower = horsePower;
        }

        public int Speed { get; set; }
        public int HorsePower { get; set; }
    }
}
