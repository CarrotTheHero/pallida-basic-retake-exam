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
            int strenght = random.Next(1, 10);
        }
    }
}