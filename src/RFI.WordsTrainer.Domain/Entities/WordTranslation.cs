namespace RFI.WordsTrainer.Domain.Entities;

public class WordTranslation
{
    public Guid Id { get; private set; }

    public Word Word1 { get; private set; }

    public Word Word2 { get; private set; }

    private WordTranslation()
    {
        Id = Guid.Empty;
        Word1 = null!;
        Word2 = null!;
    }

    private WordTranslation(Guid id, Word word1, Word word2)
    {
        Id = id;
        Word1 = word1;
        Word2 = word2;
    }

    public static WordTranslation Create(Word word1, Word word2)
        => new(Guid.NewGuid(), word1, word2);
}