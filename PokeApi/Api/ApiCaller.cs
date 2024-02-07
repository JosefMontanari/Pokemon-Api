using Newtonsoft.Json;
using PokeApi.Models;

namespace PokeApi.Api
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();
            // Lägg till en basadress eftersom alla calls kommer gå till denna sidan
            //Client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
        }

        public async Task<RootDetails> MakeCallDetails(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {

                string json = await response.Content.ReadAsStringAsync();
                RootDetails? result = JsonConvert.DeserializeObject<RootDetails>(json);

                if (result != null)
                {
                    return result;
                }

            }
            throw new HttpRequestException("Could not deserialise Json");
        }
        public async Task<Root> MakeCall(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {

                string json = await response.Content.ReadAsStringAsync();
                Root? result = JsonConvert.DeserializeObject<Root>(json);

                if (result != null)
                {
                    return result;
                }

            }
            throw new HttpRequestException("Could not deserialise Json");
        }
    }
}
