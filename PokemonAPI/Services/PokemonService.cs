using AutoMapper;
using PokemonAPI.Dtos;
using PokemonAPI.Interfaces;

namespace PokemonAPI.Services {
    public class PokemonService : IPokemonService {
        public readonly IMapper _mapper;
        public readonly IPokemonApi _pokemonApi;

        public PokemonService(IMapper mapper, IPokemonApi pokemonApi) {
            _mapper = mapper;
            _pokemonApi = pokemonApi;
        }

        public async Task<ResponseGenerico<PokemonResponse>> BuscarPokemon(string name) {
            var pokemon = await _pokemonApi.BuscarPokemonPorNome(name);
            return _mapper.Map<ResponseGenerico<PokemonResponse>>(pokemon);
        }
    }
}
