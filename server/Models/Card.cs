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
        public string? ImageUrl { get; set; }
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
        public string? ScryfallId { get; set; }
        public string? ScryfallOracleId { get; set; }
        public string? TcgplayerProductId { get; set; }
        public string? TcgplayerEtchedProductId { get; set; }
    }

    public class LeadershipSkills
    {
        public bool? Brawl { get; set; }
        public bool? Commander { get; set; }
        public bool? Oathbreaker { get; set; }
    }

    public class Legalities
    {
        public string? Alchemy { get; set; }
        public string? Brawl { get; set; }
        public string? Commander { get; set; }
        public string? Duel { get; set; }
        public string? Explorer { get; set; }
        public string? Future { get; set; }
        public string? Gladiator { get; set; }
        public string? Historic { get; set; }
        public string? Historicbrawl { get; set; }
        public string? Legacy { get; set; }
        public string? Modern { get; set; }
        public string? Oathbreaker { get; set; }
        public string? Oldschool { get; set; }
        public string? Pauper { get; set; }
        public string? Paupercommander { get; set; }
        public string? Penny { get; set; }
        public string? Pioneer { get; set; }
        public string? Predh { get; set; }
        public string? Premodern { get; set; }
        public string? Standard { get; set; }
        public string? Standardbrawl { get; set; }
        public string? Timeless { get; set; }
        public string? Vintage { get; set; }
    }

    public class PurchaseUrls
    {
        public string? CardKingdom { get; set; }
        public string? CardKingdomEtched { get; set; }
        public string? CardKingdomFoil { get; set; }
        public string? Cardmarket { get; set; }
        public string? Tcgplayer { get; set; }
        public string? TcgplayerEtched { get; set; }
    }

    public class RelatedCards
    {
        public List<string>? ReverseRelated { get; set; }
        public List<string>? Spellbook { get; set; }
    }

    public class Rulings
    {
        public string? Date { get; set; }
        public string? Text { get; set; }
    }
}
