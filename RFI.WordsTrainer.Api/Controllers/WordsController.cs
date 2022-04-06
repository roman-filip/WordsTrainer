using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RFI.WordsTrainer.Api.Models;

namespace RFI.WordsTrainer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordsController : ControllerBase
    {
        private readonly ILogger<WordsController> _logger;
        private readonly IMapper _mapper;

        public WordsController(ILogger<WordsController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<WordCategory> Get()
        {
            return _mapper.Map<IEnumerable<WordCategory>>(Enumerable.Range(1, 4).Select(index => new Data.Models.WordCategory
            {
                Id = index,
                Name = $"Testovaci kategorie - {index}"
            })
            .ToArray());
        }
    }
}