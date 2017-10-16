using System;

namespace PokeBag
{
    public class Pokemon
    {
        protected int HP;
        protected string Talking;
        protected int strength;

        public string Speak(Pokemon pokemon)
        {
            return pokemon.Talking;
        }
        public string GetStrongest()
        {
            return GetType().Name;
        }
    }
}