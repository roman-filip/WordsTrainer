using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RFI.WordsTrainer.Api.Models;
using RFI.WordsTrainer.Data;

namespace RFI.WordsTrainer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordCategoriesController : ControllerBase
    {
        private readonly ILogger<WordCategoriesController> _logger;
        private readonly IMapper _mapper;
        private readonly WordsTrainerDbContext _dbContext;

        public WordCategoriesController(ILogger<WordCategoriesController> logger, IMapper mapper, WordsTrainerDbContext dbContext)
        {
            _logger = logger;
            _mapper = mapper;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<WordCategory> Get()
            => _mapper.Map<IEnumerable<WordCategory>>(_dbContext.WordCategories.ToList());
    }
}