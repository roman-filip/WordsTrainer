using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RFI.WordsTrainer.Domain.Entities;

namespace RFI.WordsTrainer.Infrastructure.Data.EF.Configurations;

internal class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.Property(l => l.Code)
            .IsRequired()
            .HasMaxLength(2);

        builder.HasIndex(l => l.Code)
            .IsUnique();

        builder.Property(l => l.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
