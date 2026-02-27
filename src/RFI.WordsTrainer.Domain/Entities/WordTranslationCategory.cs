namespace RFI.WordsTrainer.Domain.Entities;

public class WordTranslationCategory
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    private WordTranslationCategory(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public static WordTranslationCategory Create(string name)
        => new(Guid.NewGuid(), name);
}