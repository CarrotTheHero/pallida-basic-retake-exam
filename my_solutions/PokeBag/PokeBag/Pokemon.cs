using System;

namespace PokeBag
{
    public class Pokemon
    {
        public Random random = new Random();
        protected int HP;
        protected string Talking;
        public int strength;

        public string Speak(Pokemon pokemon)
        {
            return pokemon.Talking;
        }
    }
}