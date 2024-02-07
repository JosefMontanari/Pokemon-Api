using Newtonsoft.Json;

namespace PokeApi.Models
{
	public class RootDetails
	{

		public int Height { get; set; }

		public int Id { get; set; }

		public string Name { get; set; }

		public List<TypeModel> Types { get; set; }

		public int Weight { get; set; }
		public Sprites Sprites { get; set; }
	}
	public class TypeModel
	{
		[JsonProperty("slot")]
		public int? Slot { get; set; }

		[JsonProperty("type")]
		public TypeCoreModel TypeCore { get; set; }

	}
	public class TypeCoreModel
	{
		public string Name { get; set; }
	}
	public class Sprites
	{

		[JsonProperty("front_default")]
		public string FrontDefault { get; set; }

	}
}