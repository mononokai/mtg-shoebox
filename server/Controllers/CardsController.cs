using System.Threading.Tasks;
using Elastic.Clients.Elasticsearch;
using Elastic.Clients.Elasticsearch.Core.Reindex;
using Elastic.Clients.Elasticsearch.Nodes;
using Microsoft.AspNetCore.Mvc;
using MTGShoebox.Models;

namespace MTGShoebox.Controllers
{
    // Attributes
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private ElasticsearchClient _client;

        public CardsController(ElasticsearchClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<ActionResult<List<Card>>> Get([FromQuery] string q)
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

            // !! This is test code, remove once no longer needed
            Console.WriteLine("Results:");
            foreach (var hit in response.Hits)
            {
                Console.WriteLine($"Card Name: {hit.Source.Name} - Type: {hit.Source.Type} - Mana Cost: {hit.Source.ManaCost} - Scryfall ID: {hit.Source.ScryfallId}");
            }

            var cards = response.Hits.Select(hit => hit.Source).ToList();

            // Returns a JSON formatted body with an HTTP 200 OK status
            return Ok(cards);
        }
    }
}
