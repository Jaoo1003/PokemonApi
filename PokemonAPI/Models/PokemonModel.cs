using PokemonAPI.Dtos;
using System.Text.Json.Serialization;

namespace PokemonAPI.Models {
    public class PokemonModel {
        [JsonPropertyName("name")]
        public string? Pokemon { get; set; }
        [JsonPropertyName("abilities")]
        public List<AbilitiesModel> Habilidades { get; set; }
        [JsonPropertyName("height")]
        public int Altura { get; set; }
        [JsonPropertyName("weight")]
        public int Peso { get; set; }
    }
}
