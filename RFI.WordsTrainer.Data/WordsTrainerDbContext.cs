using Microsoft.EntityFrameworkCore;
using RFI.WordsTrainer.Data.Models;

namespace RFI.WordsTrainer.Data
{
    public class WordsTrainerDbContext : DbContext
    {
        public DbSet<WordCategory>? WordCategories { get; set; }

        public WordsTrainerDbContext(DbContextOptions<WordsTrainerDbContext> options)
            : base(options)
        { }
    }
}
