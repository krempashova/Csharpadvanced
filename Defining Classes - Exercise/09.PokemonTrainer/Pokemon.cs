using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{

    
    public class Pokemon
    {
        public Pokemon  (string pokemonName, string pokemonElement, int pokemonHealth)
        {
            PokemonName = pokemonName;
            PokemonElement = pokemonElement;
            PokemonHealth = pokemonHealth;
        }

        public string PokemonName { get; set; }
        public string PokemonElement { get; set; }
        public int PokemonHealth { get; set; }

    }
}
