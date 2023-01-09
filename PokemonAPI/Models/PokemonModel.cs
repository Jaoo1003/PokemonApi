using PokemonAPI.Dtos;
using System.Text.Json.Serialization;

namespace PokemonAPI.Models {
    public class PokemonModel {
        [JsonPropertyName("name")]
        public string? Nome { get; set; }
        [JsonPropertyName("abilities")]
        public List<AbilitiesModel> Habilidades { get; set; }
        [JsonPropertyName("height")]
        public double Altura { get; set; }
        [JsonPropertyName("wight")]
        public double Peso { get; set; }
    }
}
