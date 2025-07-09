using Elastic.Clients.Elasticsearch;

namespace MTGShoebox.Models
{
    public class Card
    {
        public string Name { get; set; }
        public string ManaCost { get; set; }
        public string Type { get; set; }
    }
}
