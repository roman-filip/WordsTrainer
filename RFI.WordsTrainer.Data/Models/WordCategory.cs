﻿using System.ComponentModel.DataAnnotations;

namespace RFI.WordsTrainer.Data.Models
{
    public class WordCategory
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        public DateTime? Created { get; set; }

        [Required]
        public DateTime? Updated { get; set; }
    }
}
