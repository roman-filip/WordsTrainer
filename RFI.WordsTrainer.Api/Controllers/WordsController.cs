using Microsoft.AspNetCore.Mvc;
using RFI.WordsTrainer.Api.Models;

namespace RFI.WordsTrainer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordsController : ControllerBase
    {
        private readonly ILogger<WordsController> _logger;

        public WordsController(ILogger<WordsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WordCategory> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WordCategory
            {
                Id = index,
                Name = $"Testovaci kategorie - {index}"
            })
            .ToArray();
        }
    }
}