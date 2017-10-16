namespace PokeBag
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur()
        {
            Pokemon pokemon = new Pokemon();
            HP = 10;
            Talking = "Bulba-saur";
            strength = pokemon.random.Next(1, 10);
        }
    }
}