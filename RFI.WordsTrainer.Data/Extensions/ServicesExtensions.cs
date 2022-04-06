using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RFI.WordsTrainer.Data.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddWordsTrainerData(this IServiceCollection services)
        {
            services.AddDbContext<WordsTrainerDbContext>(opt => opt.UseInMemoryDatabase(""));
        }
    }
}
