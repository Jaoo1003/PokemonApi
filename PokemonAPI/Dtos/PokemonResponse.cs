using PokemonAPI.Models;

namespace PokemonAPI.Dtos {
    public class PokemonResponse {
        public string Nome { get; set; }
        public List<AbilitiesModel> Habilidades { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
    }
}