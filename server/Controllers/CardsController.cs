using Microsoft.AspNetCore.Mvc;
using MTGShoebox.Models;

namespace MTGShoebox.Controllers
{
    // Attributes
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        [HttpGet]
        // TODO: Change to ActionResult<List<Card>> once the Card model is made
        public ActionResult<List<Card>> Get([FromQuery] string q)
        {
            // TODO: Set up for Elastic querying
            List<Card> testData = new List<Card>
            {
                new Card { Name = "Lightning Bolt", ManaCost = "{R}", Type = "Instant" },
                new Card { Name = "Black Lotus", ManaCost = "{0}", Type = "Artifact" },
                new Card { Name = "Sol Ring", ManaCost = "{1}", Type = "Artifact"}
            };

            // Returns a JSON formatted body with an HTTP 200 OK status
            return Ok(testData);
        }
    }
}
