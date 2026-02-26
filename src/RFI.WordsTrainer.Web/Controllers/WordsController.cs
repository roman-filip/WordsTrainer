using Microsoft.AspNetCore.Mvc;
using RFI.WordsTrainer.Domain.Entities;
using RFI.WordsTrainer.Domain.Enums;

namespace RFI.WordsTrainer.Web.Controllers;

public class WordsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<WordTranslation>> Get()
    {
        return Ok(Enumerable.Range(1, 5).Select(index =>
            WordTranslation.Create(
                Word.Create($"Word {index}", Language.Cs),
                Word.Create($"Translation {index}", Language.En)
            )
        ).ToArray());
    }

    [HttpGet("{id:guid}")]
    public ActionResult<WordTranslation> Get(Guid id)
    {
        return Ok(WordTranslation.Create(
                Word.Create($"Word", Language.Cs),
                Word.Create($"Translation", Language.En)));
    }

    [HttpGet("random")]
    public ActionResult<WordTranslation> GetRandom()
    {
        return Ok(WordTranslation.Create(
                Word.Create($"Word", Language.Cs),
                Word.Create($"Translation", Language.En)));
    }
}
