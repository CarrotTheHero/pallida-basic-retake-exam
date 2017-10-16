namespace PokeBag
{
    public class Charmander : Pokemon
    {
        public Charmander()
        {
            Pokemon pokemon = new Pokemon();
            HP = 10;
            Talking = "Char-char";
            strength = pokemon.random.Next(1, 10);
        }
    }
}