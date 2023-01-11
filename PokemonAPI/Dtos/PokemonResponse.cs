using PokemonAPI.Models;

namespace PokemonAPI.Dtos {
    public class PokemonResponse {
        public string Pokemon { get; set; }
        public List<AbilitiesModel> Habilidades { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }
    }
}