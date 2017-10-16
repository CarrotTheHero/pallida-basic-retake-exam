using System;

namespace PokeBag
{
    public class Pokemon
    {
        protected int HP;
        protected string Talking;
        protected int strength;

        public string Speak()
        {
            return Talking;
        }
        public void GetStrongest()
        {
            Console.WriteLine();
        }
    }
}