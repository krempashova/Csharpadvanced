﻿using System;
using System.Text;
using Basketball;

namespace Basketball
{
    public class Player
    {

        public Player(string name, string position, double rating, int games)
        {
            Name = name;
            Position = position;
            Rating = rating;
            Games = games;
        }

        public string Name { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }

        public int Games { get; set; }
        public bool Retired { get; set; } = false;

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Player: {Name}");
            sb.AppendLine($"--Position: {Position}");
            sb.AppendLine($"--Rating: {Rating}");
            sb.AppendLine($"--Games played: {Games}");


            return sb.ToString().Trim();

        }
    }
}
