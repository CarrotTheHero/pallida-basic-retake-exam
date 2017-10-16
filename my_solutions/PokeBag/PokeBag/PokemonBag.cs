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
                int strogest = pokemon.strength;
                if (pokemon.strength > strogest)
                {
                    strogest = pokemon.strength;
                }
                return strogest.GetType().Name;
            }
            return "";
        }
    }
}
