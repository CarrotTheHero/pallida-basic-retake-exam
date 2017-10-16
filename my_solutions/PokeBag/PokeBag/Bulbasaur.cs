using System;

namespace PokeBag
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur()
        {
            HP = 10;
            Talking = "Bulba-saur";
            Random random = new Random();
            strength = random.Next(1, 10);
        }
    }
}