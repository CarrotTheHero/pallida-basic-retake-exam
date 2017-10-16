using System;

namespace PokeBag
{
    public class Pokemon
    {
        protected int HP;
        protected string Talking;
        public int strength;

        public string Speak(Pokemon pokemon)
        {
            return pokemon.Talking;
        }
    }
}