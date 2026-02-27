using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RFI.WordsTrainer.Domain.Entities;

namespace RFI.WordsTrainer.Infrastructure.Data.EF.Configurations;

internal class WordTranslationConfiguration : IEntityTypeConfiguration<WordTranslation>
{
    public void Configure(EntityTypeBuilder<WordTranslation> builder)
    {
        builder.HasOne<Word>(wt => wt.Word1)
            .WithMany()
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne<Word>(wt => wt.Word2)
            .WithMany()
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne<WordTranslationCategory>(wtc => wtc.Category)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
