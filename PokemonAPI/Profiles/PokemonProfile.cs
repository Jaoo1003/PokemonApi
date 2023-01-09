using AutoMapper;
using PokemonAPI.Dtos;
using PokemonAPI.Models;

namespace PokemonAPI.Profiles {
    public class PokemonProfile : Profile{
        public PokemonProfile() {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<PokemonResponse, PokemonModel>();
            CreateMap<PokemonModel, PokemonResponse>();
        }
    }
}
