using Elastic.Clients.Elasticsearch;
using Microsoft.AspNetCore.Mvc;
using MTGShoebox.Models;
using MTGShoebox.Services;


namespace MTGShoebox.Controllers
{
    // Attributes
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private ElasticsearchClient _client;
        private CardSearchService _searchService;

        public CardsController(ElasticsearchClient client, CardSearchService searchService)
        {
            _client = client;
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Card>>> Get([FromQuery] string query)
        {
            var cards = await _searchService.SearchCards(query);
            
            // Returns a JSON formatted body with an HTTP 200 OK status
            return Ok(cards);
        }
    }
}
