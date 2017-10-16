using System;

namespace PokeBag
{
    public class Pokemon
    {
        protected int HP;
        protected string Talking;

        public void Speak(string talking)
        {
            Talking = talking;
            
        }
    }
}