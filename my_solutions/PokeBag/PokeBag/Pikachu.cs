namespace PokeBag
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            Pokemon pokemon = new Pokemon();
            HP = 12;
            Talking = "Pika-pika";
            strength = pokemon.random.Next(1, 10);
        }
    }
}