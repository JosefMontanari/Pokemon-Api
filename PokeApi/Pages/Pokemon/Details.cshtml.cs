using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeApi.Api;
using PokeApi.Models;

namespace PokeApi.Pages.Pokemon
{
	public class DetailsModel : PageModel
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public int Height { get; set; }
		public int Weight { get; set; }
		public List<TypeCoreModel> Types { get; set; }
		public string ErrorMessage { get; set; }
		public string Url { get; set; }
		public string Img { get; set; }
		public async Task OnGet(string id)
		{
			Url = id;
			try
			{
				RootDetails result = await new ApiCaller().MakeCallDetails(Url);
				Name = result.Name;
				Height = result.Height;
				Weight = result.Weight;
				// Selecta en class och casta den som en annan för att hämta alla elementen i denna
				// För om alla "types" till en TypeCore och lista dessa
				Types = result.Types.Select(t => t.TypeCore).ToList();
				Id = result.Id;
				Img = result.Sprites.FrontDefault;


			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;

			}
		}
	}
}
