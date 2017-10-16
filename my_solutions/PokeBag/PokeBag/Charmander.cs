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
            int strenght = random.Next(1, 10);
        }
    }
}