using Elastic.Clients.Elasticsearch;
using MTGShoebox.Models;

namespace MTGShoebox.Services
{
    public class CardSearchService
    {
        private ElasticsearchClient _client;

        public CardSearchService(ElasticsearchClient client)
        {
            _client = client;
        }

        public async Task<List<Card>> SearchCards(string q)
        {
            var response = await _client.SearchAsync<Card>(search => search
                .Indices("mtg_cards")
                .Query(query => query
                    .Match(match => match
                        .Field(field => field.Name)
                            .Query(q)
                    )
                )
                .Size(10) // TODO: Adjust the size once pagination is implemented
            );

            var cards = response.Hits.Select(hit => hit.Source!).ToList();

            return cards;
        }
    }
}