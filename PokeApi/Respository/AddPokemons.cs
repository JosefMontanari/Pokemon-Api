using PokeApi.Database;

namespace PokeApi.Respository;

public class AddPokemons
{
    private readonly AppDbContext _context;

    //public void AddToDatabase(PokemonFromApi pokemonFromApi)
    //{
    //    PokemonDbModel pokemonToAddToDb = new()
    //    {
    //        Name = pokemonFromApi.Name,
    //        Height = pokemonFromApi.Height,
    //        Weight = pokemonFromApi.Weight,
    //        Type = pokemonFromApi.Type,

    //    };

    //    _context.Pokemon.Add(pokemonToAddToDb);

    //    _context.SaveChanges();
    //}
}
