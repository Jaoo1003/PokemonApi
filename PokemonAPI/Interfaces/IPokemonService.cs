using PokemonAPI.Dtos;

namespace PokemonAPI.Interfaces {
    public interface IPokemonService {
        Task<ResponseGenerico<PokemonResponse>> BuscarPokemonPorNome(string name);
    }
}
