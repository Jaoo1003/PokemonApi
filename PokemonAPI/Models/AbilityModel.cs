using System.Text.Json.Serialization;

namespace PokemonAPI.Models {
    public class AbilityModel {
        [JsonPropertyName("name")]
        public string? Nome { get; set; }
        [JsonPropertyName("url")]
        [JsonIgnore]
        public string Url { get; set; }
    }
}
