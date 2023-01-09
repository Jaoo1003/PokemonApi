using PokemonAPI.Dtos;
using PokemonAPI.Interfaces;
using PokemonAPI.Models;
using System.Dynamic;
using System.Text.Json;

namespace PokemonAPI.Rest {
    public class PokemonApiRest : IPokemonApi {

        public async Task<ResponseGenerico<PokemonModel>> BuscarPokemonPorNome(string name) {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://pokeapi.co/api/v2/pokemon/{name.ToLower()}");

            var response = new ResponseGenerico<PokemonModel>();
            using (var client = new HttpClient()) {
                var responsePokemonApi = await client.SendAsync(request);
                var contentResponse = await responsePokemonApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<PokemonModel>(contentResponse);

                if (responsePokemonApi.IsSuccessStatusCode) {
                    response.CodigoHttp = responsePokemonApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else {
                    response.CodigoHttp = responsePokemonApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }
        public Task<ResponseGenerico<AbilitiesModel>> BuscarAbilities() {
            throw new NotImplementedException();
        }        
    }
}