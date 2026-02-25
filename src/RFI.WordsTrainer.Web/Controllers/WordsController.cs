using Microsoft.AspNetCore.Mvc;
using RFI.WordsTrainer.Domain.Entities;
using RFI.WordsTrainer.Domain.Enums;

namespace RFI.WordsTrainer.Web.Controllers;

public class WordsController : ControllerBase
{
    [HttpGet]
    public IEnumerable<WordTranslation> Get()
    {
        return Enumerable.Range(1, 5).Select(index =>
            WordTranslation.Create(
                Word.Create($"Word {index}", Language.Cs),
                Word.Create($"Translation {index}", Language.En)
            )
        ).ToArray();
    }
}
