using System;

namespace PokeBag
{
    public class Charmander : Pokemon
    {
        public Charmander()
        {
            HP = 10;
            Talking = "Char-char";
            Random random = new Random();
            strength = random.Next(1, 10);
        }
    }
}