using System.ComponentModel.DataAnnotations;

namespace PokeApi.Models;

public class PokemonDbModel
{
	[Key]
	public int PokemonId { get; set; }
	public string Name { get; set; }
	public int Height { get; set; }
	public int Weight { get; set; }
	public string Type { get; set; }
	public string Url { get; set; }
}


