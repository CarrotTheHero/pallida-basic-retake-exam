﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBag
{
    // Create a PokeBag class that can store multiple pokemons from different types. Add 5 pokemons to your PokeBag.
    // There are 3 kind of pomenons:
    // - Pikachu, who says “Pika-pika” and has 12 HP (health point)
    // - Bubasaur, who says “Bulba-saur” and has 10 HP
    // - Charmander, who says “Char-char” and has 10 HP
    // Every pokemon has a random strength between 1 and 10.
    // Pokemons can say their sound (see above) when their Speak method is called. The Speak method should return the pokemon’s sound.
    // Create a function that returns the pokemon with the highest strength. In case of equal strengths, it’s your choice which one to return.
    // 
    // Example:
    // pokeBag.Add(new Pikachu());
    // pokeBag.Add(new Pikachu());
    // pokeBag.Add(new Pikachu());
    // pokeBag.Add(new Bulbasaur());
    // pokeBag.Add(new Charmander());
    // 
    // Console.WriteLine(pokeBag[0].Speak());
    // This should print Pika-pika
    // 
    // var stongestPokemon = pokeBag.GetStrongest();
    // Should return the pokemon with the highest strength value

    class Program
    {
        static void Main(string[] args)
        {
            Pikachu pikachu = new Pikachu();
            Bulbasaur bulbasaur = new Bulbasaur();
            Charmander charmander = new Charmander();

            PokemonBag pokemonBag = new PokemonBag();
            pokemonBag.pokeBag.Add(new Pikachu());
            pokemonBag.pokeBag.Add(new Pikachu());
            pokemonBag.pokeBag.Add(new Pikachu());
            pokemonBag.pokeBag.Add(new Bulbasaur());
            pokemonBag.pokeBag.Add(new Charmander());

            Console.WriteLine(pokemonBag.pokeBag[0].Speak(pikachu));

            //string stongestPokemon = PokemonBag.GetStrongest();
            Console.ReadLine();
        }
    }
}
