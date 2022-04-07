using System.ComponentModel.DataAnnotations;

namespace RFI.WordsTrainer.Data.Models
{
    public class DbEntityBase
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public DateTime? Created { get; set; }

        [Required]
        public DateTime? Updated { get; set; }
    }
}