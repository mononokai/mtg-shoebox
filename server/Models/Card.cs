using System.Text.Json.Serialization;

namespace MTGShoebox.Models
{
    public class Card
    {
        public string? Name { get; set; }
        public string? ManaCost { get; set; }
        public string? Type { get; set; }

        [JsonPropertyName("identifiers")]
        public Identifiers Identifiers { get; set; }

        [JsonPropertyName("scryfallId")]
        public string? ScryfallId => Identifiers?.ScryfallId;
    }

    public class Identifiers
    {
        [JsonPropertyName("scryfallId")]
        public string ScryfallId { get; set; }
    }
}
