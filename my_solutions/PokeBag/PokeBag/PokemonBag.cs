using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeBag;

namespace PokeBag
{
    class PokemonBag
    {
        public List<Pokemon> pokeBag;

        public PokemonBag()
        {
            pokeBag.Add(new Pikachu());
            pokeBag.Add(new Pikachu());
            pokeBag.Add(new Pikachu());
            pokeBag.Add(new Bulbasaur());
            pokeBag.Add(new Charmander());
        }
    }
}
