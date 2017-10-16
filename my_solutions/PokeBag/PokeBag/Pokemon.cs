using System;

namespace PokeBag
{
    public class Pokemon
    {
        protected int HP;
        protected string Talking;

        public bool Speak()
        {
            Console.WriteLine("{0}", Talking);
            return true;
        }
    }
}