using Microsoft.EntityFrameworkCore;
using PokeApi.Models;

namespace PokeApi.Database;


public class AppDbContext : DbContext
{
	public DbSet<PokemonDbModel> Pokemon { get; set; }

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	public DbSet<PokemonFromDatabase> Pokemons { get; set; }
}
