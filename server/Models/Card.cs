using System.Text.Json.Serialization;

namespace MTGShoebox.Models
{
    public class Card
    {
        public string? Artist { get; set; }
        public List<string>? ArtistIds { get; set; }
        public List<string>? CardParts { get; set; }
        public List<string>? ColorIdentity { get; set; }
        public List<string>? Colors { get; set; }
        public string? Defense { get; set; }
        public int? EdhrecRank { get; set; }
        public double? EdhrecSaltiness { get; set; }
        public string? FlavorName { get; set; }
        public string? FlavorText { get; set; }
        public List<string>? FrameEffects { get; set; }
        public Identifiers? Identifiers { get; set; }
        public bool? IsFullArt { get; set; }
        public bool? IsPromo { get; set; }
        public bool? IsRebalanced { get; set; }
        public bool? IsReserved { get; set; }
        public bool? IsReprint { get; set; }
        public bool? IsStarter { get; set; }
        public bool? IsStorySpotlight { get; set; }
        public bool? IsTextless { get; set; }
        public List<string>? Keywords { get; set; }
        public string? Layout { get; set; }
        public LeadershipSkills? LeadershipSkills { get; set; }
        public Legalities? Legalities { get; set; }
        public string? Life { get; set; }
        public string? Loyalty { get; set; }
        public string? ManaCost { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }
        public List<string>? OriginalPrintings { get; set; }
        public List<string>? OtherFaceIds { get; set; }
        public string? Power { get; set; }
        public List<string>? Printings { get; set; }
        public List<string>? PromoTypes { get; set; }

        public PurchaseUrls? PurchaseUrls { get; set; }
        public string? Rarity { get; set; }
        public RelatedCards? RelatedCards { get; set; }
        public List<string>? RebalancedPrintings { get; set; }
        public List<Rulings>? Rulings { get; set; }
        public string? SecurityStamp { get; set; }
        public string? SetCode { get; set; }
        public List<string>? SubTypes { get; set; }
        public List<string>? SuperTypes { get; set; }
        public string? Text { get; set; }
        public string? Toughness { get; set; }
        public string? Type { get; set; }
        public List<string>? Types { get; set; }
        public required string Uuid { get; set; }
        public List<string>? Variations { get; set; }
    }

    public class Identifiers
    {
        [JsonPropertyName("scryfallId")]
        public string? ScryfallId { get; set; }
        [JsonPropertyName("scryfallOracleId")]
        public string? ScryfallOracleId { get; set; }
        [JsonPropertyName("tcgplayerProductId")]
        public string? TcgplayerProductId { get; set; }
        [JsonPropertyName("tcgplayerEtchedProductId")]
        public string? TcgplayerEtchedProductId { get; set; }
    }

    public class LeadershipSkills
    {
        [JsonPropertyName("brawl")]
        public bool? Brawl { get; set; }
        [JsonPropertyName("commander")]
        public bool? Commander { get; set; }
        [JsonPropertyName("oathbreaker")]
        public bool? Oathbreaker { get; set; }
    }

    public class Legalities
    {
        [JsonPropertyName("alchemy")]
        public string? Alchemy { get; set; }
        [JsonPropertyName("brawl")]
        public string? Brawl { get; set; }
        [JsonPropertyName("commander")]
        public string? Commander { get; set; }
        [JsonPropertyName("duel")]
        public string? Duel { get; set; }
        [JsonPropertyName("explorer")]
        public string? Explorer { get; set; }
        [JsonPropertyName("future")]
        public string? Future { get; set; }
        [JsonPropertyName("gladiator")]
        public string? Gladiator { get; set; }
        [JsonPropertyName("historic")]
        public string? Historic { get; set; }
        [JsonPropertyName("historicbrawl")]
        public string? Historicbrawl { get; set; }
        [JsonPropertyName("legacy")]
        public string? Legacy { get; set; }
        [JsonPropertyName("modern")]
        public string? Modern { get; set; }
        [JsonPropertyName("oathbreaker")]
        public string? Oathbreaker { get; set; }
        [JsonPropertyName("oldschool")]
        public string? Oldschool { get; set; }
        [JsonPropertyName("pauper")]
        public string? Pauper { get; set; }
        [JsonPropertyName("paupercommander")]
        public string? Paupercommander { get; set; }
        [JsonPropertyName("penny")]
        public string? Penny { get; set; }
        [JsonPropertyName("pioneer")]
        public string? Pioneer { get; set; }
        [JsonPropertyName("predh")]
        public string? Predh { get; set; }
        [JsonPropertyName("premodern")]
        public string? Premodern { get; set; }
        [JsonPropertyName("standard")]
        public string? Standard { get; set; }
        [JsonPropertyName("standardbrawl")]
        public string? Standardbrawl { get; set; }
        [JsonPropertyName("timeless")]
        public string? Timeless { get; set; }
        [JsonPropertyName("vintage")]
        public string? Vintage { get; set; }
    }

    public class PurchaseUrls
    {
        [JsonPropertyName("cardKingdom")]
        public string? CardKingdom { get; set; }
        [JsonPropertyName("cardKingdomEtched")]
        public string? CardKingdomEtched { get; set; }
        [JsonPropertyName("cardKingdomFoil")]
        public string? CardKingdomFoil { get; set; }
        [JsonPropertyName("cardmarket")]
        public string? Cardmarket { get; set; }
        [JsonPropertyName("tcgplayer")]
        public string? Tcgplayer { get; set; }
        [JsonPropertyName("tcgplayerEtched")]
        public string? TcgplayerEtched { get; set; }
    }

    public class RelatedCards
    {
        [JsonPropertyName("reverseRelated")]
        public List<string>? ReverseRelated { get; set; }
        [JsonPropertyName("spellbook")]
        public List<string>? Spellbook { get; set; }
    }

    public class Rulings
    {
        [JsonPropertyName("date")]
        public string? Date { get; set; }
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
