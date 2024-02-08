using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeApi.Database;
using PokeApi.Models;

namespace PokeApi.Pages.Pokemon
{
    public class DatabaseModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public List<PokemonDbModel> Pokemons { get; set; } = new List<PokemonDbModel>();

        public DatabaseModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void OnGet()
        {
            foreach (var pokemon in _dbContext.Pokemon)
            {
                PokemonDbModel pokemonToAdd = new()
                {
                    Name = pokemon.Name,
                    Height = pokemon.Height,
                    Weight = pokemon.Weight,
                    Url = pokemon.Url,
                    Type = pokemon.Type,

                };

                Pokemons.Add(pokemonToAdd);
            }
        }
    }
}
