using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeApi.Database;
using PokeApi.Models;

namespace PokeApi.Pages.Pokemon
{
	public class DatabaseModel : PageModel
	{
		private readonly AppDbContext _dbContext;


		public DatabaseModel(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<PokemonFromDatabase> Pokemons { get; set; }

		public void OnGet()
		{
			Pokemons = _dbContext.Pokemons.ToList();

		}
	}
}
