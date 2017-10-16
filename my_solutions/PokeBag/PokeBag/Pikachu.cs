using System;

namespace PokeBag
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            HP = 12;
            Talking = "Pika-pika";
            Random random = new Random();
            strength = random.Next(1, 10);

        }
    }
}