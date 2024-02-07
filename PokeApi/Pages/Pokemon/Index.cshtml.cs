using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeApi.Api;
using PokeApi.Models;

namespace PokeApi.Pages.Pokemon
{
    public class IndexModel : PageModel
    {
        public List<Result> Pokemons { get; set; }
        public string ErrorMessage { get; set; }

        public async Task OnGet()
        {
            try
            {
                Root result = await new ApiCaller().MakeCall("https://pokeapi.co/api/v2/pokemon/?limit=100");
                Pokemons = result.Results;

            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;

            }

        }
    }
}
