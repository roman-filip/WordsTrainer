using Microsoft.AspNetCore.Mvc;
using RFI.WordsTrainer.Domain.Entities;

namespace RFI.WordsTrainer.Web.Controllers;

public class WordsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<WordTranslation>> Get()
    {
        return Ok(Enumerable.Range(1, 5).Select(index =>
            WordTranslation.Create(
                Word.Create($"Word {index}", Language.Create("CS", "Cestina")),
                Word.Create($"Translation {index}", Language.Create("EN", "Anglictina"))
            )
        ).ToArray());
    }

    [HttpGet("{id:guid}")]
    public ActionResult<WordTranslation> Get(Guid id)
    {
        return Ok(WordTranslation.Create(
                Word.Create($"Word", Language.Create("CS", "Cestina")),
                Word.Create($"Translation", Language.Create("EN", "Anglictina"))));
    }

    [HttpGet("random")]
    public ActionResult<WordTranslation> GetRandom()
    {
        return Ok(WordTranslation.Create(
                Word.Create($"Word", Language.Create("CS", "Cestina")),
                Word.Create($"Translation", Language.Create("EN", "Anglictina"))));
    }
}
