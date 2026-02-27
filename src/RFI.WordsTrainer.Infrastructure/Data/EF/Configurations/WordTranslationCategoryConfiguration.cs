using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RFI.WordsTrainer.Domain.Entities;

namespace RFI.WordsTrainer.Infrastructure.Data.EF.Configurations;

internal class WordTranslationCategoryConfiguration : IEntityTypeConfiguration<WordTranslationCategory>
{
    public void Configure(EntityTypeBuilder<WordTranslationCategory> builder)
    {
        builder.Property(wtc => wtc.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}