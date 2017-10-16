using System.Collections.Generic;

namespace PokeBag
{
    public class PokemonBag
    {
        public List<Pokemon> pokeBag = new List<Pokemon>();

        public string GetStrongest()
        {
            foreach (var pokemon in pokeBag)
            {
                int strongest = pokemon.strength;
                if (pokemon.strength > strongest)
                {
                    strongest = pokemon.strength;
                }
                return strongest.GetType().Name;
            }
            return "";
        }
    }
}
