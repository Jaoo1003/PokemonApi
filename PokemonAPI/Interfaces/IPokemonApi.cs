using PokemonAPI.Dtos;
using PokemonAPI.Models;

namespace PokemonAPI.Interfaces {
    public interface IPokemonApi {
        Task<ResponseGenerico<PokemonModel>> BuscarPokemonPorNome(string name);
        Task<ResponseGenerico<AbilitiesModel>> BuscarAbilities();
    }
}
