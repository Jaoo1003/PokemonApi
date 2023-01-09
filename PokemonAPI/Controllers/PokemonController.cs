using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Interfaces;
using System.Net;

namespace PokemonAPI.Controllers {
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PokemonController : ControllerBase{
        public readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService enderecoService) {
            _pokemonService = enderecoService;
        }

        [HttpGet("buscar/{name}")]
        public async Task<IActionResult> BuscarPokemon([FromRoute] string name) {
            var response = await _pokemonService.BuscarPokemon(name);

            if (response.CodigoHttp == HttpStatusCode.OK) {
                return Ok(response.DadosRetorno);
            }
            else {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}