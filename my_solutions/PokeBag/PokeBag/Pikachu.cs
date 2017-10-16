using System;

namespace PokeBag
{
    public class Pikachu : Pokemon
    {
        public Random random = new Random();
        public Pikachu()
        {
            Pokemon pokemon = new Pokemon();
            HP = 12;
            Talking = "Pika-pika";
            strength = random.Next(1, 10);
        }
    }
}