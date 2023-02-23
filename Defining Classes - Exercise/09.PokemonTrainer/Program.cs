using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer;

public class Programs
{
    static void Main(string[] args)
    {
        List<Trainer> trainers = new();
        string command = string.Empty;
        while ((command = Console.ReadLine())!= "Tournament")
        {

            string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Trainer trainer = trainers.SingleOrDefault(t => t.TrainerName == input[0]);

            if (trainer == null)
            {
                trainer = new(input[0]);
                trainer.Pokemons.Add(new(input[1], input[2], int.Parse(input[3])));
                trainers.Add(trainer);
            }
            else
            {
                trainer.Pokemons.Add(new(input[1], input[2], int.Parse(input[3])));
            }
        }

        while ((command = Console.ReadLine())!="End")
        {
            foreach (var trainer in trainers)
            {
                trainer.CheckPokemon(command);
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.TrainerName} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
        }
    }
}