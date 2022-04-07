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
        public IEnumerable<Word> Get()
        {
            return _mapper.Map<IEnumerable<Word>>(Enumerable.Range(1, 10).Select(index => new Data.Models.Word
            {
                Id = index
            })
            .ToArray());
        }

        [HttpGet]
        [Route("random")]
        public Word GetRandomWord()
        {
            return _mapper.Map<Word>(new Data.Models.Word { Id = Random.Shared.Next(1000) });
        }
    }
}
