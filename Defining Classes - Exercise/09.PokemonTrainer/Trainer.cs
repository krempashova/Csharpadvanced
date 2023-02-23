using System;
using PokemonTrainer;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string trainerName)
        {
            TrainerName = trainerName;
            Pokemons = new();
        }
    
        public string TrainerName { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }


        public void CheckPokemon(string pokemonElement)
        {
            if (Pokemons.Any(p => p.PokemonElement == pokemonElement))
            {
                NumberOfBadges++;
            }
            else
            {
                for (int i = 0; i < Pokemons.Count; i++)
                {
                    Pokemon currentPokemon = Pokemons[i];

                    currentPokemon.PokemonHealth -= 10;

                    if (currentPokemon.PokemonHealth <= 0)
                    {
                        Pokemons.Remove(currentPokemon);
                    }
                }
            }
        }
    }
}
   

