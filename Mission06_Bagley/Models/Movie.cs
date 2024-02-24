﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Bagley.Models
{
    public class Movie
    {
        //information about the movie.

        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]

        public int? CategoryId { get; set; }

        // Navigation Property
        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage ="There were no movies before 1888!")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public bool? Edited { get; set; }

        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex {  get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
