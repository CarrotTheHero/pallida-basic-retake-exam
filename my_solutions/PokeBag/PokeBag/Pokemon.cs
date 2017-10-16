using System;

namespace PokeBag
{
    public class Pokemon
    {
        protected int HP;
        protected string Talking;
        public int strength;
        public Random random = new Random();

        public string Speak(Pokemon pokemon)
        {
            return pokemon.Talking;
        }
    }
}