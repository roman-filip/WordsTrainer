using RFI.WordsTrainer.Domain.Interfaces;

namespace RFI.WordsTrainer.Domain.Entities;

public class Word : IEntity
{
    public Guid Id { get; private set; }

    public string Text { get; private set; }

    public Language Language { get; private set; }

    private Word()
    {
        Id = Guid.Empty;
        Text = null!;
        Language = null!;
    }

    private Word(Guid id, string text, Language language)
    {
        Id = id;
        Text = text;
        Language = language;
    }

    public static Word Create(string text, Language language)
        => new(Guid.NewGuid(), text, language);
}
