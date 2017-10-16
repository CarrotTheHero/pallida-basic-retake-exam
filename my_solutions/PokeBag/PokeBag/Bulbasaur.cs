using System;

namespace PokeBag
{
    public class Bulbasaur : Pokemon
    {
        public Random random = new Random();
        public Bulbasaur()
        {
            Pokemon pokemon = new Pokemon();
            HP = 10;
            Talking = "Bulba-saur";
            strength = random.Next(1, 10);
        }
    }
}