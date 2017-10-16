using System;

namespace PokeBag
{
    public class Charmander : Pokemon
    {
        public Random random = new Random();
        public Charmander()
        {
        Pokemon pokemon = new Pokemon();
            HP = 10;
            Talking = "Char-char";
            strength = random.Next(1, 10);
        }
    }
}