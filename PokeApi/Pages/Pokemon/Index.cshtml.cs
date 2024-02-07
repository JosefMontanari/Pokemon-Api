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
                Root result = await new ApiCaller().MakeCall("pokemon/");
                Pokemons = result.Result;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;

            }

        }
    }
}
