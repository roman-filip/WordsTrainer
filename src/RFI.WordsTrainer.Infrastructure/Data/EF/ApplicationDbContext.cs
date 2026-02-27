using System.Reflection;
using Microsoft.EntityFrameworkCore;
using RFI.WordsTrainer.Domain.Entities;

namespace RFI.WordsTrainer.Infrastructure.Data.EF;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Word> Words => Set<Word>();

    public DbSet<WordTranslation> WordTranslations => Set<WordTranslation>();

    public DbSet<WordTranslationCategory> WordTranslationCategories => Set<WordTranslationCategory>();

    public DbSet<Language> Languages => Set<Language>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
