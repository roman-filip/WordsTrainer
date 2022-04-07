using System.ComponentModel.DataAnnotations;

namespace RFI.WordsTrainer.Data.Models
{
    public class WordCategory : DbEntityBase
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
    }
}
