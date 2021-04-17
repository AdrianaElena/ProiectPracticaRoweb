using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryData.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(300, MinimumLength = 1)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public decimal Price { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
