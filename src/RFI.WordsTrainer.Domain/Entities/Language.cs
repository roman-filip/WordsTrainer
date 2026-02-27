using RFI.WordsTrainer.Domain.Interfaces;

namespace RFI.WordsTrainer.Domain.Entities;

public class Language : IEntity
{
    public Guid Id { get; private set; }

    public string Code { get; private set; }

    public string Name { get; private set; }

    private Language(Guid id, string code, string name)
    {
        Id = id;
        Code = code;
        Name = name;
    }

    public static Language Create(string code, string name)
        => new(Guid.NewGuid(), code, name);
}
